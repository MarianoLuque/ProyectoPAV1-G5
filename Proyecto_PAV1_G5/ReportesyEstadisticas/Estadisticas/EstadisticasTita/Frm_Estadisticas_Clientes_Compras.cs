using Microsoft.Reporting.WinForms;
using Proyecto_PAV1_G5.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasTita
{
    public partial class Frm_Estadisticas_Clientes_Compras : Form
    {
        DataTable tabla = new DataTable();
        NE_Clientes cliente = new NE_Clientes();

        public Frm_Estadisticas_Clientes_Compras()
        {
            InitializeComponent();
        }

        private void Frm_Estadisticas_Clientes_Compras_Load(object sender, EventArgs e)
        {
            txt_fecha.ReadOnly = true;
            this.rp_cliente_compra.RefreshReport();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            rb_fecha.Checked = false;
            rb_facturas.Checked = false;
            txt_fecha.Text = "";
            txt_fecha.ReadOnly = true;
            this.rp_cliente_compra.RefreshReport();
        }

        private void rb_fecha_CheckedChanged(object sender, EventArgs e)
        {
            txt_fecha.ReadOnly = false;
        }

        private void rb_facturas_CheckedChanged(object sender, EventArgs e)
        {
            txt_fecha.ReadOnly = true;
        }

        private void btn_generar_Click(object sender, EventArgs e)
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
            if (rb_facturas.Checked == true)
            {
                banderaRB2 = true;
            }
            if (rb_facturas.Checked == false && rb_fecha.Checked == false)
            {
                MessageBox.Show("Falta elegir el tipo de patron a aplicar para la estadística");
                return false;
            }
            if (banderaRB1)
            {
                tabla = cliente.ReporteVentasXCliente(banderaRB1, txt_fecha.Text);
            }
            if (banderaRB2)
            {
                tabla = cliente.ReporteVentasXCliente(banderaRB1, "");
            }
            return true;
        }

        private void CargarReporte()
        {
            string restriccion = "Restricciones: \n";

            if (rb_fecha.Checked)
            {
                string[] subcadenasFecha = txt_fecha.Text.Split('/');
                restriccion += "  - Para el año " + subcadenasFecha[2] + " y el mes " + subcadenasFecha[1] + "\n";
            }

            if (rb_facturas.Checked)
            {
                restriccion += "  - Para todos las facturas registradas ";
            }

            ReportDataSource datos = new ReportDataSource("DataSetFacturasYEmpleados", tabla);

            rp_cliente_compra.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasTita.Estadisticas_Cliente_Compras.rdlc";
            rp_cliente_compra.LocalReport.DataSources.Clear();
            rp_cliente_compra.LocalReport.DataSources.Add(datos);

            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("Rp02", restriccion);
            rp_cliente_compra.LocalReport.SetParameters(parametro);
            rp_cliente_compra.RefreshReport();
        }

    }
}
