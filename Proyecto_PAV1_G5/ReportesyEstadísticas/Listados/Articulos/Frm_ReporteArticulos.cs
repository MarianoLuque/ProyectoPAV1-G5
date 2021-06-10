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
using Proyecto_PAV1_G5.Clases;
using Proyecto_PAV1_G5.Negocios;

namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    public partial class Frm_ReporteArticulos : Form
    {
        Tratamientos_Especiales TratEsp = new Tratamientos_Especiales();
        DataTable tabla = new DataTable();
        NE_Articulos articulo = new NE_Articulos();
        public Frm_ReporteArticulos()
        {
            InitializeComponent();
        }

        private void Frm_ReporteArticulos_Load(object sender, EventArgs e)
        {
            this.reporte_articulos.RefreshReport();
            cmb_proveedores.CargarCombo(articulo.DatosComboProveedor());
            btn_buscar.Enabled = false;
            txt_cantDesde.Enabled = false;
            txt_cantHasta.Enabled = false;
            cmb_proveedores.Enabled = false;
            txt_NombreArticulo.Enabled = false;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            cmb_proveedores.SelectedIndex = -1;
            txt_cantDesde.Text = "";
            txt_cantHasta.Text = "";
            txt_NombreArticulo.Text = "";
            btn_todos.Checked = false;
        }

        private void btn_todos_CheckedChanged(object sender, EventArgs e)
        {
            cmb_proveedores.SelectedIndex = -1;
            cmb_proveedores.Enabled = false;
            btn_buscar.Enabled = true;
            txt_cantHasta.Text = "";
            txt_cantHasta.Enabled = false;
            txt_cantDesde.Text = "";
            txt_cantDesde.Enabled = false;
            txt_NombreArticulo.Text = "";
            txt_NombreArticulo.Enabled = false;
        }

        private void btn_filtros_CheckedChanged(object sender, EventArgs e)
        {
            cmb_proveedores.SelectedIndex = -1;
            cmb_proveedores.Enabled = true;
            btn_buscar.Enabled = false;
            txt_cantHasta.Text = "";
            txt_cantHasta.Enabled = true;
            txt_cantDesde.Text = "";
            txt_cantDesde.Enabled = true;
            txt_NombreArticulo.Text = "";
            txt_NombreArticulo.Enabled = true;
            btn_buscar.Enabled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            RecuperarArticulos();
            ArmarReporte(tabla);
        }

        private void RecuperarArticulos()
        {
            if (cmb_proveedores.SelectedIndex == -1 && txt_NombreArticulo.Text == "")
            {
                if (txt_cantDesde.Text == "" && txt_cantHasta.Text == "")
                {
                    tabla = articulo.RecuperarArticulosSinStock();
                }
                if (txt_cantDesde.Text != "" && txt_cantHasta.Text == "")
                {
                    tabla = articulo.RecuperarArticulosConStockDesde(txt_cantDesde.Text);
                }
                if (txt_cantDesde.Text == "" && txt_cantHasta.Text != "")
                {
                    tabla = articulo.RecuperarArticulosConStockHasta(txt_cantHasta.Text);
                }
                if (txt_cantDesde.Text != "" && txt_cantHasta.Text != "")
                {
                    tabla = articulo.RecuperarArticulosConStock(txt_cantDesde.Text, txt_cantHasta.Text);
                }
                return;
            }

            if (cmb_proveedores.SelectedIndex != -1 && txt_NombreArticulo.Text == "")
            {
                if (txt_cantDesde.Text == "" && txt_cantHasta.Text == "")
                {
                    tabla = articulo.RecuperarArticulosPorProveedor(cmb_proveedores.SelectedValue.ToString());
                }
                if (txt_cantDesde.Text != "" && txt_cantHasta.Text == "")
                {
                    tabla = articulo.RecuperarArticulosPorProveedoryStockDesde(cmb_proveedores.SelectedValue.ToString(), txt_cantDesde.Text);
                }
                if (txt_cantDesde.Text == "" && txt_cantHasta.Text != "")
                {
                    tabla = articulo.RecuperarArticulosPorProveedoryStockHasta(cmb_proveedores.SelectedValue.ToString(), txt_cantHasta.Text);
                }
                if (txt_cantDesde.Text != "" && txt_cantHasta.Text != "")
                {
                    tabla = articulo.RecuperarArticulosPorProveedoryStock(cmb_proveedores.SelectedValue.ToString(), txt_cantDesde.Text, txt_cantHasta.Text);
                }
                return;
            }

            if (cmb_proveedores.SelectedIndex != -1 && txt_NombreArticulo.Text != "")
            {
                if (txt_cantDesde.Text == "" && txt_cantHasta.Text == "")
                {
                    tabla = articulo.RecuperarArticulosProveedorPatron(cmb_proveedores.SelectedValue.ToString(), txt_NombreArticulo.Text);
                }
                if (txt_cantDesde.Text != "" && txt_cantHasta.Text == "")
                {
                    tabla = articulo.RecuperarArticulosProveedorPatronyStockDesde(cmb_proveedores.SelectedValue.ToString(), txt_NombreArticulo.Text, txt_cantDesde.Text);
                }
                if (txt_cantDesde.Text == "" && txt_cantHasta.Text != "")
                {
                    tabla = articulo.RecuperarArticulosProveedorPatron(cmb_proveedores.SelectedValue.ToString(), txt_NombreArticulo.Text);
                }
                if (txt_cantDesde.Text != "" && txt_cantHasta.Text != "")
                {
                    tabla = articulo.RecuperarArticulosPorProveedoryStock(cmb_proveedores.SelectedValue.ToString(), txt_cantDesde.Text, txt_cantHasta.Text);
                }
                return;
            }

            if (cmb_proveedores.SelectedIndex == -1 && txt_NombreArticulo.Text != "")
            {
                if (txt_cantDesde.Text != "" && txt_cantHasta.Text != "")
                {
                    tabla = articulo.RecuperarArticulosPatronStock(txt_NombreArticulo.Text, txt_cantDesde.Text, txt_cantHasta.Text);
                }
                if (txt_cantDesde.Text != "" && txt_cantHasta.Text == "")
                {
                    tabla = articulo.RecuperarArticulosPatronStockDesde(txt_NombreArticulo.Text, txt_cantDesde.Text);
                }
                if (txt_cantDesde.Text == "" && txt_cantHasta.Text != "")
                {
                    tabla = articulo.RecuperarArticulosPatronStockHasta(txt_NombreArticulo.Text, txt_cantHasta.Text);
                }
                if (txt_cantDesde.Text == "" && txt_cantHasta.Text == "")
                {
                    tabla = articulo.RecuperarArticulosPatron(txt_NombreArticulo.Text);
                }
                return;
            }

        }

        private void ArmarReporte(DataTable tabla)
        {
            ReportDataSource datosArticulos = new ReportDataSource("DataSet1", tabla);
            reporte_articulos.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadísticas.Listados.Articulos.ListadoArticulos.rdlc";
            reporte_articulos.LocalReport.DataSources.Clear();
            reporte_articulos.LocalReport.DataSources.Add(datosArticulos);
            reporte_articulos.RefreshReport();
             
        }

        
    }
}
