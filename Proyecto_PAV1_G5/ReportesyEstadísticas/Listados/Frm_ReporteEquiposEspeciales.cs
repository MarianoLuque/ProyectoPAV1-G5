using Microsoft.Reporting.WinForms;
using Proyecto_PAV1_G5.BackEnd;
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
    public partial class Frm_ReporteEquiposEspeciales : Form
    {
        NE_EquiposEspeciales equiposEs = new NE_EquiposEspeciales();
        DataTable tabla = new DataTable();


        public Frm_ReporteEquiposEspeciales()
        {
            InitializeComponent();
        }

        private void Frm_ReporteEquiposEspeciales_Load(object sender, EventArgs e)
        {
            cmb_clientes.CargarCombo(equiposEs.DatosComboCliente());
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            cmb_clientes.SelectedIndex = -1;
            txt_precio_min.Text = "";
            txt_precio_max.Text = "";
            rb_todos.Checked = false;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            RecuperarDatosEquipos();
            ArmarReporteEquipoEspecial(tabla);

        }
        public void RecuperarDatosEquipos()
        {
            
            if (rb_todos.Checked == true)
            {
                tabla = equiposEs.RecuperarTodos();

            }
            if(txt_precio_max.Text != "")
            {
                tabla = equiposEs.Recuperar_X_Precio_Max(txt_precio_max.Text);
            }
            if(txt_precio_min.Text != "")
            {
                tabla = equiposEs.Recuperar_X_Precio_Min(txt_precio_min.Text);
            }
            if(txt_precio_min.Text != "" && txt_precio_max.Text != "")
            {
                tabla = equiposEs.Recuperar_X_Limites_Precios(txt_precio_min.Text, txt_precio_max.Text);
            }
            if(cmb_clientes.SelectedIndex != -1)
            {
                tabla = equiposEs.Recuperar_Cuit_Cliente(cmb_clientes.SelectedValue.ToString());
            }

        }

        private void ArmarReporteEquipoEspecial(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
            reporte_equipos_especiales.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadísticas.Listados.ListadoEquipoEspecial.rdlc";
            reporte_equipos_especiales.LocalReport.DataSources.Clear();
            reporte_equipos_especiales.LocalReport.DataSources.Add(PaqueteDatos);
            reporte_equipos_especiales.RefreshReport();
        }
    }
}
