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

namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    public partial class Frm_ReporteClasificacionesClientes : Form
    {
        public Frm_ReporteClasificacionesClientes()
        {
            InitializeComponent();
        }

        private void Frm_ReporteEquiposEspeciales_Load(object sender, EventArgs e)
        {
            this.reporte_clasificacion.RefreshReport();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            this.reporte_clasificacion.Clear();
            txt_antiguedad.Text = "";
            txt_cantidad_compras.Text = "";
            rb_todos.Checked = false;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            NE_Categoria categoria = new NE_Categoria();

            if (rb_todos.Checked == true)
            {
                tabla = categoria.RecuperarTodos();
                ArmarReporteClasificacion(tabla);
            }
            if (txt_cantidad_compras.Text != "" && txt_antiguedad.Text == "")
            {
                tabla = categoria.Recuperar_x_cantidad_compras(txt_cantidad_compras.Text);
                ArmarReporteClasificacion(tabla);
            }
            if (txt_cantidad_compras.Text == "" && txt_antiguedad.Text != "")
            {
                tabla = categoria.Recuperar_x_antiguedad(txt_antiguedad.Text);
                ArmarReporteClasificacion(tabla);
            }

            if (txt_cantidad_compras.Text != "" && txt_antiguedad.Text != "")
            {
                tabla = categoria.Recuperar_x_antiguedad_y_cantidad_compras(txt_antiguedad.Text, txt_cantidad_compras.Text);
                ArmarReporteClasificacion(tabla);
            }

        }

        private void ArmarReporteClasificacion(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
            reporte_clasificacion.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadísticas.Listados.ClasificacionesClientes.ListadoClasificacion.rdlc";
            reporte_clasificacion.LocalReport.DataSources.Clear();
            reporte_clasificacion.LocalReport.DataSources.Add(PaqueteDatos);
            reporte_clasificacion.RefreshReport();
        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_todos.Checked)
            {
                txt_antiguedad.Enabled = false;
                txt_cantidad_compras.Enabled = false;
            }

            else
            {
                txt_antiguedad.Enabled = true;
                txt_cantidad_compras.Enabled = true;
            }
        }

        private void txt_antiguedad_TextChanged(object sender, EventArgs e)
        {
            if(txt_antiguedad.Text != "")
            {
                txt_cantidad_compras.Enabled = false;
                rb_todos.Enabled = false;
            }
            else
            {
                txt_cantidad_compras.Enabled = true;
                rb_todos.Enabled = true;
            }
        }

        private void txt_cantidad_compras_TextChanged(object sender, EventArgs e)
        {
            if(txt_cantidad_compras.Text != "")
            {
                txt_antiguedad.Enabled = false;
                rb_todos.Enabled = false;
            }
            else
            {
                txt_antiguedad.Enabled = true;
                rb_todos.Enabled = true;
            }
        }
    }
}
