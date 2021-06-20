using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Proyecto_PAV1_G5.Negocios;

namespace Proyecto_PAV1_G5.ReportesyEstadísticas.Estadisticas.EstadisticasMariano
{
    public partial class Frm_Estadistica_Compras_Por_Proveedor : Form
    {
        DataTable Tabla = new DataTable();
        NE_Proveedores proveedor = new NE_Proveedores();

        public Frm_Estadistica_Compras_Por_Proveedor()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_Compras_Por_Proveedor_Load(object sender, EventArgs e)
        {
            txt_fecha.ReadOnly = true;
            this.reporte_compras_proveedor.RefreshReport();
        }

        private void CargarReporte()
        {
            string restriccion = "Restricciones: \n";

            if (rb_fecha.Checked)
            {
                string[] subcadenasFecha = txt_fecha.Text.Split('/');
                restriccion += "  - Para el año " + subcadenasFecha[2] + " y el mes " + subcadenasFecha[1] + "\n";
            }

            if (rb_todos.Checked)
            {
                restriccion += "  - Para todos los remitos registrados ";
            }

            ReportDataSource datos = new ReportDataSource("DataSetFormaDePagoYComprasPorProveedor", Tabla);

            reporte_compras_proveedor.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasMariano.Estadistica_Cantidad_De_Compras_Por_Proveedor.rdlc";
            reporte_compras_proveedor.LocalReport.DataSources.Clear();
            reporte_compras_proveedor.LocalReport.DataSources.Add(datos);
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RPRestriccion", restriccion);
            reporte_compras_proveedor.LocalReport.SetParameters(parametro);
            reporte_compras_proveedor.RefreshReport();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            rb_fecha.Checked = false;
            rb_todos.Checked = false;
            txt_fecha.Text = "";
            txt_fecha.ReadOnly = true;
            this.reporte_compras_proveedor.RefreshReport();
        }

        private void rb_fecha_CheckedChanged(object sender, EventArgs e)
        {
            txt_fecha.ReadOnly = false;
        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {
            txt_fecha.ReadOnly = true;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (BuscarDatos())
            {
                CargarReporte();
            }
        }

        private bool BuscarDatos()
        {
            bool banderaRB1 = false;
            bool banderaRB2 = false;

            if (rb_fecha.Checked == true)
            {
                banderaRB1 = true;
            }
            if (rb_todos.Checked == true)
            {
                banderaRB2 = true;
            }
            if (rb_todos.Checked == false && rb_fecha.Checked == false)
            {
                MessageBox.Show("Falta elegir el tipo de patron a aplicar para la estadística");
                return false;
            }
            if (banderaRB1)
            {
                Tabla = proveedor.ReporteComprasXProveedor(banderaRB1, txt_fecha.Text);
            }
            if (banderaRB2)
            {
                Tabla = proveedor.ReporteComprasXProveedor(banderaRB1, "");
            }
            return true;
        }
    }
}
