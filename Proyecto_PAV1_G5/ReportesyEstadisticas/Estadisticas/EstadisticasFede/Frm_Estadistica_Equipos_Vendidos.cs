using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAV1_G5.Negocios;
using Microsoft.Reporting.WinForms;

namespace Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasFede
{
    public partial class Frm_Estadistica_Equipos_Vendidos : Form
    {
        NE_Ventas ventas = new NE_Ventas();
        DataTable tabla = new DataTable();

        public Frm_Estadistica_Equipos_Vendidos()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_Equipos_Vendidos_Load(object sender, EventArgs e)
        {
            cmb_tipo_factura.CargarCombo(ventas.DatosComboTipoFactura());
            cmb_tipo_factura.Enabled = false;
            txt_fecha.ReadOnly = true;
            this.reporte_equipos.RefreshReport();
        }

        private bool BuscarDatos()
        {
            bool banderaRB1 = false;
            bool banderaRB2 = false;
            bool banderaRB3 = false;
            bool banderaRB4 = false;

            if (rb_fecha.Checked == true)
            {
                banderaRB1 = true;
            }
            if (rb_tipo_factura.Checked == true)
            {
                banderaRB2 = true;
            }
            if (rb_ambos.Checked == true)
            {
                banderaRB3 = true;
            }
            if (rb_todo.Checked == true)
            {
                banderaRB4 = true;
            }
            if (rb_todo.Checked == false && rb_ambos.Checked == false && rb_fecha.Checked == false && rb_tipo_factura.Checked == false)
            {
                MessageBox.Show("Falta seleccionar un filtro para la estadística");
                return false;
            }
            if (rb_simple.Checked == true)
            {
                if (banderaRB2 || banderaRB3)
                {
                    tabla = ventas.EstadisticaEquipos(banderaRB1, banderaRB2, banderaRB3, txt_fecha.Text, cmb_tipo_factura.SelectedValue.ToString());
                }
                if (banderaRB1 || banderaRB4)
                {
                    tabla = ventas.EstadisticaEquipos(banderaRB1, banderaRB2, banderaRB3, txt_fecha.Text, "");
                }
            }
            if (rb_especial.Checked == true)
            {
                
                if (banderaRB2 || banderaRB3)
                {
                    tabla = ventas.EstadisticaEquiposEsp(banderaRB1, banderaRB2, banderaRB3, txt_fecha.Text, cmb_tipo_factura.SelectedValue.ToString());
                }
                if (banderaRB1 || banderaRB4)
                {
                    tabla = ventas.EstadisticaEquiposEsp(banderaRB1, banderaRB2, banderaRB3, txt_fecha.Text, "");
                }
            }

            return true;
        }
        //
        private void CargarReporte()
        {
            string restriccion = "Restricciones: \n";

            if (rb_ambos.Checked || rb_fecha.Checked)
            {
                string[] subcadenasFecha = txt_fecha.Text.Split('/');
                restriccion += "  - Para el año " + subcadenasFecha[2] + " y el mes " + subcadenasFecha[1] + "\n";
            }

            if (rb_ambos.Checked || rb_tipo_factura.Checked)
            {
                restriccion += "  - Para el tipo de factura " + cmb_tipo_factura.Text + "\n";
            }

            if (rb_todo.Checked)
            {
                restriccion += "  - Para todas las facturas registradas ";
            }

            ReportDataSource datos = new ReportDataSource("DataSetEquipos", tabla);

            reporte_equipos.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasFede.Estadistica_Equipos.rdlc";
            reporte_equipos.LocalReport.DataSources.Clear();
            reporte_equipos.LocalReport.DataSources.Add(datos);
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("ReportParameterEquipos", restriccion);
            reporte_equipos.LocalReport.SetParameters(parametro);
            reporte_equipos.RefreshReport();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (BuscarDatos())
            {
                CargarReporte();
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            rb_fecha.Checked = false;
            rb_tipo_factura.Checked = false;
            rb_ambos.Checked = false;
            rb_todo.Checked = false;
            txt_fecha.Text = "";
            cmb_tipo_factura.SelectedIndex = -1;
            txt_fecha.ReadOnly = true;
            cmb_tipo_factura.Enabled = false;
            rb_especial.Checked = false;
            rb_simple.Checked = false;
            this.reporte_equipos.RefreshReport();
        }

        private void rb_fecha_CheckedChanged(object sender, EventArgs e)
        {
            txt_fecha.ReadOnly = false;
            cmb_tipo_factura.Enabled = false;
        }

        private void rb_tipo_factura_CheckedChanged(object sender, EventArgs e)
        {
            txt_fecha.ReadOnly = true;
            cmb_tipo_factura.Enabled = true;
        }

        private void rb_todo_CheckedChanged(object sender, EventArgs e)
        {
            txt_fecha.ReadOnly = true;
            cmb_tipo_factura.Enabled = false;
        }

        private void rb_ambos_CheckedChanged(object sender, EventArgs e)
        {
            txt_fecha.ReadOnly = false;
            cmb_tipo_factura.Enabled = true;
        }

        private void rb_especial_CheckedChanged(object sender, EventArgs e)
        {
            rb_tipo_factura.Enabled = false;
            rb_ambos.Enabled = false;
            cmb_tipo_factura.Enabled = false;
        }

        private void rb_simple_CheckedChanged(object sender, EventArgs e)
        {
            rb_tipo_factura.Enabled = true;
            rb_ambos.Enabled = true;
            cmb_tipo_factura.Enabled = true;
        }
    }
}
