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

namespace Proyecto_PAV1_G5.ReportesyEstadísticas.Estadísticas
{
    public partial class Frm_Estadistica_Tipo_Producto : Form
    {
        NE_Ventas venta = new NE_Ventas();
        

        public Frm_Estadistica_Tipo_Producto()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_Ventas_Load(object sender, EventArgs e)
        {
            txt_fecha.ReadOnly = true;
            cmb_tipo_factura.CargarCombo(venta.DatosComboTipoFactura());
            this.rv_tipo_producto.RefreshReport();
            rb_fecha.Checked = false;
            rb_tipo_factura.Checked = false;
            cmb_tipo_factura.Enabled = false;
            txt_fecha.ReadOnly = true;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            rb_fecha.Checked = false;
            rb_tipo_factura.Checked = false;
            txt_fecha.Text = "";
            txt_fecha.ReadOnly = true;
            cmb_tipo_factura.SelectedIndex = -1;
            this.rv_tipo_producto.RefreshReport();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            if (rb_fecha.Checked == true)
            {
                if(txt_fecha.Text != "")
                {
                    tabla = venta.Recuperar_por_mes(txt_fecha.Text);
                    ArmarEstadistica(tabla);
                }
                if(txt_fecha.Text == "")
                {
                    MessageBox.Show("Para poder usar este filtro necesita ingresar un mes del 1 al 12");
                    txt_fecha.Focus();
                }
            }
            if(rb_tipo_factura.Checked == true)
            {
                if (cmb_tipo_factura.SelectedIndex != -1)
                {
                    tabla = venta.Recuperar_por_tipo_factura(cmb_tipo_factura.SelectedValue.ToString());
                    ArmarEstadistica(tabla);
                }
                if(cmb_tipo_factura.SelectedIndex == -1)
                {
                    MessageBox.Show("Para poder usar este filtro, debe seleccionar un tipo de factura");
                    cmb_tipo_factura.Focus();
                }
            }
        }

        private void ArmarEstadistica(DataTable tabla)
        {
            string restriccion = "Restriccion: \n";

            if (rb_fecha.Checked)
            {
                string[] subcadenasFecha = txt_fecha.Text.Split('/');
                restriccion += "  - Para el año " + subcadenasFecha[2] + " y el mes " + subcadenasFecha[1] + "\n";
            }

            if (rb_tipo_factura.Checked)
            {
                restriccion = " - Para el tipo de Factura: " + cmb_tipo_factura.SelectedValue.ToString();
            }

            ReportDataSource datosVenta = new ReportDataSource("DataSet1", tabla);
            rv_tipo_producto.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadisticas.Estadisticas.EstadisticasFlor.Estadistica_Tipo_Productos.rdlc";

            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("Parametro1", restriccion);

            rv_tipo_producto.LocalReport.SetParameters(parametros);
            rv_tipo_producto.LocalReport.DataSources.Clear();
            rv_tipo_producto.LocalReport.DataSources.Add(datosVenta);
            rv_tipo_producto.RefreshReport();

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
    }
}
