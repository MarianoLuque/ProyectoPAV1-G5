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

namespace Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasVale
{
    public partial class Frm_Estadistica_Articulos : Form
    {
        NE_Ventas venta = new NE_Ventas();
        DataTable Tabla = new DataTable();
        public Frm_Estadistica_Articulos()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_Articulos_Load(object sender, EventArgs e)
        {
            cmb_tipo_factura.CargarCombo(venta.DatosComboTipoFactura());
            this.reporte_articulos.RefreshReport();
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
            if (banderaRB1 || banderaRB3)
            {
                Tabla = venta.EstadisticaArticulos(banderaRB1, banderaRB2, banderaRB3, txt_fecha.Text, cmb_tipo_factura.SelectedValue.ToString());
            }
            if (banderaRB2 || banderaRB4)
            {
                Tabla = venta.EstadisticaArticulos(banderaRB1, banderaRB2, banderaRB3, txt_fecha.Text, "");
            }
            return true;
        }

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

            ReportDataSource datos = new ReportDataSource("DataSetArticulos", Tabla);

            reporte_articulos.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasVale.Estadistica_ArticulosMasVendidos.rdlc";
            reporte_articulos.LocalReport.DataSources.Clear();
            reporte_articulos.LocalReport.DataSources.Add(datos);
            ReportParameter[] parametro = new ReportParameter[1];
            parametro[0] = new ReportParameter("RPRestriccion", restriccion);
            reporte_articulos.LocalReport.SetParameters(parametro);
            reporte_articulos.RefreshReport();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if(BuscarDatos())
            {
                CargarReporte();
            }
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
            this.reporte_articulos.RefreshReport();
        }
    }
}
