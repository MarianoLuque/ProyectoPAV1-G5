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
    public partial class Frm_Estadistica_Empleado_Ventas : Form
    {
        DataTable tabla = new DataTable();
        NE_Empleados empleado = new NE_Empleados();

        public Frm_Estadistica_Empleado_Ventas()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_Empleado_Ventas_Load(object sender, EventArgs e)
        {
            txt_fecha.ReadOnly = true;
            this.rp_empleados_ventas.RefreshReport();
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

            rp_empleados_ventas.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasTita.Estadisticas_Empleados_Ventas.rdlc";
            rp_empleados_ventas.LocalReport.DataSources.Clear();
            rp_empleados_ventas.LocalReport.DataSources.Add(datos);

            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("Rp01",restriccion);
            rp_empleados_ventas.LocalReport.SetParameters(parametro);
            rp_empleados_ventas.RefreshReport();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            rb_fecha.Checked = false;
            rb_facturas.Checked = false;
            txt_fecha.Text = "";
            txt_fecha.ReadOnly = true;
            this.rp_empleados_ventas.RefreshReport();
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
                tabla = empleado.ReporteVentaXEmpleado(banderaRB1, txt_fecha.Text);
            }
            if (banderaRB2)
            {
                tabla = empleado.ReporteVentaXEmpleado(banderaRB1, "");
            }
            return true;
        }
    }
}
