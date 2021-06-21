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

namespace Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasFede
{
    public partial class Frm_Estadistica_Ventas_Cantidad : Form
    {
        DataTable tabla = new DataTable();
        NE_Ventas venta = new NE_Ventas();
        public Frm_Estadistica_Ventas_Cantidad()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_Forma_De_Pago_Load(object sender, EventArgs e)
        {
            txt_fecha.ReadOnly = false;
            this.reporte_venta_cantidad.RefreshReport();
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
                restriccion += "  - Para todas las facturas registradas ";
            }

            ReportDataSource datos = new ReportDataSource("DataSetVentasCantidad", tabla);

            reporte_venta_cantidad.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasFede.Estadistica_VentasCantidad.rdlc";
            reporte_venta_cantidad.LocalReport.DataSources.Clear();
            reporte_venta_cantidad.LocalReport.DataSources.Add(datos);
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("ReportParameterVentas", restriccion);
            reporte_venta_cantidad.LocalReport.SetParameters(parametro);
            reporte_venta_cantidad.RefreshReport();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            rb_fecha.Checked = false;
            rb_todos.Checked = false;
            txt_fecha.Text = "";
            txt_fecha.ReadOnly = true;
            this.reporte_venta_cantidad.RefreshReport();
        }

        private void rb_fecha_CheckedChanged(object sender, EventArgs e)
        {
            txt_fecha.ReadOnly = false;
            txt_fecha.Clear();
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

            if (rb_fecha.Checked == true)
            {
                tabla = venta.EstadisticaVentasCantidad(txt_fecha.Text);
            }

            if (rb_todos.Checked == true)
            {
                tabla = venta.EstadisticaVentasCantidadTodos();
            }
            if (rb_todos.Checked == false && rb_fecha.Checked == false)
            {
                MessageBox.Show("Falta elegir el tipo de patron a aplicar para la estadística");
                return false;
            }
            return true;
        }
    }
}
