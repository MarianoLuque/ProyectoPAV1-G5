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
using Proyecto_PAV1_G5.Clases;
using Microsoft.Reporting.WinForms;

namespace Proyecto_PAV1_G5.Reportes_y_Estadísticas.Listados
{
    public enum Estado { correcto, error }
    public partial class Frm_ReporteEquiposSimples : Form
    {
        NE_Equipos_Simples equip = new NE_Equipos_Simples();
        DataTable Tabla = new DataTable();
        Tratamientos_Especiales te = new Tratamientos_Especiales();
        public Frm_ReporteEquiposSimples()
        {
            InitializeComponent();
        }

        private void Frm_ReporteEquiposSimples_Load(object sender, EventArgs e)
        {



        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarEquipos();

        }

        private void BuscarEquipos()
        {
            DataTable tabla = new DataTable();
            if (Rb01.Checked == false && Rb02.Checked == false && Rb03.Checked == false && Rb04.Checked == false && txt_codigo_equipoDesde.Text == "" && txt_codigo_equipoDesde.Text == "" && txt_codigo_equipoDesde.Text == "")
            {
                MessageBox.Show("Seleccione algunos datos antes de realizar el reporte");
                txt_codigo_equipoDesde.Focus();
                return;
            }
            if (Rb03.Checked == false && Rb04.Checked == false)
            {
                MessageBox.Show("Seleccione el tipo de reporte antes de realizarlo");
                return;
            }
            if (Rb01.Checked == false && Rb02.Checked == false && Rb00.Checked == false)
            {
                MessageBox.Show("Seleccione el tipo de cálculo antes de realizar el reporte");
                return;
            }
            if (Rb03.Checked == true)
            {
                if (Rb01.Checked == true)
                {
                    tabla = equip.RecuperarTodos();
                    ArmarReporteRemito1(tabla);
                }

                if (Rb02.Checked == true && txt_codigo_equipoDesde.Text != "" && txt_codigo_equipoHasta.Text != "")
                {
                    tabla = equip.RecuperarPorRango(txt_codigo_equipoDesde.Text, txt_codigo_equipoHasta.Text);
                    ArmarReporteRemito1(tabla);
                }


                if (Rb00.Checked == true && txt_nombre_equipo.Text != "")
                {
                    tabla = equip.Recuperar_x_Nombre(txt_nombre_equipo.Text);
                    ArmarReporteRemito1(tabla);
                }


            }
            if (Rb04.Checked == true)
            {
                if (Rb01.Checked == true)
                {
                    tabla = equip.RecuperarTodos2();
                    ArmarReporteRemito1(tabla);
                }

                if (Rb02.Checked == true && txt_codigo_equipoDesde.Text != "" && txt_codigo_equipoHasta.Text != "")
                {
                    tabla = equip.RecuperarPorRango2(txt_codigo_equipoDesde.Text, txt_codigo_equipoHasta.Text);
                    ArmarReporteRemito1(tabla);
                }

                if (Rb00.Checked == true && txt_nombre_equipo.Text != "")
                {
                    tabla = equip.Recuperar_x_Nombre2(txt_nombre_equipo.Text);
                    ArmarReporteRemito1(tabla);
                }
            }
        }
        private void ArmarReporteRemito1(DataTable tabla)
        {
            
            if (Rb03.Checked == true)
            {
                ReportDataSource paqueteDatos = new ReportDataSource("DataSet1", tabla);
                reporte_equipos_simples.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadisticas.Listados.EquiposSimples.Report1.rdlc";
                reporte_equipos_simples.LocalReport.DataSources.Clear();
                reporte_equipos_simples.LocalReport.DataSources.Add(paqueteDatos);
                reporte_equipos_simples.RefreshReport();
            }
            else
            {
                ReportDataSource paqueteDatos2 = new ReportDataSource("DataSetEquipArt", tabla);
                reporte_equipos_simples.LocalReport.ReportEmbeddedResource = "Proyecto_PAV1_G5.ReportesyEstadisticas.Listados.EquiposSimples.Report2.rdlc";
                reporte_equipos_simples.LocalReport.DataSources.Clear();
                reporte_equipos_simples.LocalReport.DataSources.Add(paqueteDatos2);
                reporte_equipos_simples.RefreshReport();
            }

        }

        private void Rb01_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb01.Checked == true)
            {
                txt_codigo_equipoDesde.Clear();
                txt_codigo_equipoDesde.ReadOnly = true;
                txt_codigo_equipoHasta.Clear();
                txt_codigo_equipoHasta.ReadOnly = true;
                txt_nombre_equipo.Clear();
                txt_nombre_equipo.ReadOnly = true;
                Rb00.Checked = false;
            }

            if (Rb02.Checked == true)
            {
                txt_codigo_equipoDesde.Clear();
                txt_codigo_equipoDesde.ReadOnly = false;
                txt_codigo_equipoHasta.Clear();
                txt_codigo_equipoHasta.ReadOnly = false;
                txt_nombre_equipo.Clear();
                txt_nombre_equipo.ReadOnly = true;
                Rb00.Checked = false;
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rb00_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb00.Checked == true)
            {
                txt_codigo_equipoDesde.Clear();
                txt_codigo_equipoDesde.ReadOnly = true;
                txt_codigo_equipoHasta.Clear();
                txt_codigo_equipoHasta.ReadOnly = true;
                txt_nombre_equipo.Clear();
                txt_nombre_equipo.ReadOnly = false;
                Rb01.Checked = false;
                Rb02.Checked = false;
            }
        }
    }
}