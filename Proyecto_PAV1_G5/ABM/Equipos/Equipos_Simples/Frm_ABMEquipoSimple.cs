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

namespace Proyecto_PAV1_G5.ABM.Equipos.Equipos_Simples
{
    public partial class Frm_ABMEquipoSimple : Form
    {
        // ZONA DE DECLARACIONES 
        public string[] Pp_codigo_equipo { get; set; }

        // CONSTRUCTOR
        public Frm_ABMEquipoSimple()
        {
            InitializeComponent();
        }

        // BOTON AGREGAR
        private void btn_Agregar_Equipo_Click(object sender, EventArgs e)
        {
            Frm_Alta_Equipo_Simple altaEquipo = new Frm_Alta_Equipo_Simple();
            altaEquipo.ShowDialog();
        }

        // METODO PARA CARGAR LA GRILLA
        private void CargarGrilla(DataTable tabla)
        {
            //Voy a recorrer la tabla con su contenido para cargar la grilla
            grid_Equipos_Simples.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_Equipos_Simples.Rows.Add();
                grid_Equipos_Simples.Rows[i].Cells[0].Value = tabla.Rows[i]["codigo_equipo"].ToString();
                grid_Equipos_Simples.Rows[i].Cells[1].Value = tabla.Rows[i]["precio_mayorista"].ToString();
                grid_Equipos_Simples.Rows[i].Cells[2].Value = tabla.Rows[i]["precio_minorista"].ToString();
                grid_Equipos_Simples.Rows[i].Cells[3].Value = tabla.Rows[i]["nombre_equipo"].ToString();
            }

        }

        //private void grid_Equipos_Simples_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    string[] Pp_codigo_equipo = new string[1];
        //    Pp_codigo_equipo[0] = grid_Equipos_Simples.CurrentRow.Cells["codigo_equipo"].Value.ToString();
        //}

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            NE_Equipos_Simples equiposSi = new NE_Equipos_Simples();

            if (txt_Codigo_Equipo.Text == "" && txt_Nombre_Equipo.Text == "")
            {
                CargarGrilla(equiposSi.RecuperarTodos());
            }
            if (txt_Codigo_Equipo.Text != "" && txt_Nombre_Equipo.Text != "")
            {
                CargarGrilla(equiposSi.Recuperar_Mixto(txt_Codigo_Equipo.Text, txt_Nombre_Equipo.Text));
                return;
            }
            if (txt_Codigo_Equipo.Text != "" && txt_Nombre_Equipo.Text == "")
            {
                CargarGrilla(equiposSi.Recuperar_x_Codigo_Equipo(txt_Codigo_Equipo.Text));
            }
            if (txt_Nombre_Equipo.Text != "" && txt_Codigo_Equipo.Text == "")
            {
                CargarGrilla(equiposSi.Recuperar_x_Nombre(txt_Nombre_Equipo.Text));
            }
        }

        private void btn_Modificar_Equipo_Click(object sender, EventArgs e)
        {
            Frm_Modificacion_Equipo_Simple modificacionEquipo = new Frm_Modificacion_Equipo_Simple();
            string[] Pp_codigo_equipo = new string[1];
            Pp_codigo_equipo[0] = grid_Equipos_Simples.CurrentRow.Cells["codigo_equipo"].Value.ToString();
            //NO OLVIDARSE DE ASIGNAR EL PP AL PP DE MODIFICACIONES
            modificacionEquipo.Pp_codigo_equipo = Pp_codigo_equipo;
            modificacionEquipo.ShowDialog();
        }

        private void grid_Equipos_Simples_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] Pp_codigo_equipo = new string[1];
            Pp_codigo_equipo[0] = grid_Equipos_Simples.CurrentRow.Cells["codigo_equipo"].Value.ToString();
        }

        private void btn_Eliminar_Equipo_Click(object sender, EventArgs e)
        {
            Frm_Baja_Equipo_Simple bajaEquipo = new Frm_Baja_Equipo_Simple();
            string[] Pp_codigo_equipo = new string[1];
            Pp_codigo_equipo[0] = grid_Equipos_Simples.CurrentRow.Cells["codigo_equipo"].Value.ToString();
            //NO OLVIDARSE DE ASIGNAR EL PP AL PP DE MODIFICACIONES
            bajaEquipo.Pp_codigo_equipo = Pp_codigo_equipo;
            bajaEquipo.ShowDialog();
        }
    }
}