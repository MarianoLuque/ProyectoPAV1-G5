using Proyecto_PAV1_G5.BackEnd;
using Proyecto_PAV1_G5.Clases;
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

namespace Proyecto_PAV1_G5.ABM.Equipos.Equipos_Especiales
{
    public partial class Frm_ABMEquipo : Form
    {
        public string TipoEquipo { get; set; }
        
        public string[] Pp_codigo_y_cuit_equipo_especial { get; set; }
        public string[] Pp_codigo_equipo_simple { get; set; }
        NE_EquiposEspeciales equiposEs = new NE_EquiposEspeciales();
        Acceso_Datos _BD = new Acceso_Datos();
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

        public Frm_ABMEquipo()
        {
            InitializeComponent();
        }

        //BOTON AGREGAR
        private void btn_Agregar_Equipo_Especial_Click(object sender, EventArgs e)
        {
            Frm_Alta_Equipo_Especial altaEqEsp = new Frm_Alta_Equipo_Especial();
            altaEqEsp.TipoEquipo = TipoEquipo;
            altaEqEsp.ShowDialog();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            if (TipoEquipo == "especial")
            {
                if (txt_Codigo_Equipo.Text == "" && txt_Nombre_Equipo.Text == "" && txt_Cuit_Cliente.Text == "")
                {
                    grid_equipos.Cargar(equiposEs.RecuperarTodos());
                }
                if (txt_Codigo_Equipo.Text == "" && txt_Nombre_Equipo.Text == "" && txt_Cuit_Cliente.Text != "")
                {
                    grid_equipos.Cargar(equiposEs.Recuperar_Cuit_Cliente(txt_Cuit_Cliente.Text));
                }
                if (txt_Cuit_Cliente.Text == "" && txt_Nombre_Equipo.Text == "" && txt_Codigo_Equipo.Text != "")
                {
                    grid_equipos.Cargar(equiposEs.Recuperar_x_Codigo_Equipo(txt_Codigo_Equipo.Text));
                }
                if (txt_Cuit_Cliente.Text == "" && txt_Codigo_Equipo.Text == "" && txt_Nombre_Equipo.Text != "")
                {
                    grid_equipos.Cargar(equiposEs.Recuperar_x_Nombre(txt_Nombre_Equipo.Text));
                }
                if (txt_Cuit_Cliente.Text == "" && txt_Codigo_Equipo.Text != "" && txt_Nombre_Equipo.Text != "")
                {
                    grid_equipos.Cargar(equiposEs.Recuperar_x_Nombre_y_Codigo(txt_Nombre_Equipo.Text, txt_Codigo_Equipo.Text));
                }
                if (txt_Cuit_Cliente.Text != "" && txt_Codigo_Equipo.Text == "" && txt_Nombre_Equipo.Text != "")
                {
                    grid_equipos.Cargar(equiposEs.Recuperar_x_Cuit_y_Nombre(txt_Cuit_Cliente.Text, txt_Nombre_Equipo.Text));
                }
                if (txt_Cuit_Cliente.Text != "" && txt_Codigo_Equipo.Text != "" && txt_Nombre_Equipo.Text == "")
                {
                    grid_equipos.Cargar(equiposEs.Recuperar_x_Cuit_y_Codigo(txt_Cuit_Cliente.Text, txt_Codigo_Equipo.Text));
                }
                if (txt_Cuit_Cliente.Text != "" && txt_Codigo_Equipo.Text != "" && txt_Nombre_Equipo.Text != "")
                {
                    grid_equipos.Cargar(equiposEs.Recuperar_x_Cuit_Nombre_y_Codigo(txt_Cuit_Cliente.Text, txt_Nombre_Equipo.Text, txt_Codigo_Equipo.Text));
                }
            }
            
            if (TipoEquipo == "simple")
            {
                if (txt_Codigo_Equipo.Text == "" && txt_Nombre_Equipo.Text == "")
                {
                    grid_equipos.Cargar(equiposEs.RecuperarTodos_Simple());
                }
                if (txt_Codigo_Equipo.Text != "" && txt_Nombre_Equipo.Text != "")
                {
                    grid_equipos.Cargar(equiposEs.Recuperar_Mixto_Simple(txt_Codigo_Equipo.Text, txt_Nombre_Equipo.Text));
                    return;
                }
                if (txt_Codigo_Equipo.Text != "" && txt_Nombre_Equipo.Text == "")
                {
                    grid_equipos.Cargar(equiposEs.Recuperar_x_Codigo_Equipo_Simple(txt_Codigo_Equipo.Text));
                }
                if (txt_Nombre_Equipo.Text != "" && txt_Codigo_Equipo.Text == "")
                {
                    grid_equipos.Cargar(equiposEs.Recuperar_x_Nombre_Simple(txt_Nombre_Equipo.Text));
                }
            }
        }


        private void btn_Modificar_Equipo_Especial_Click(object sender, EventArgs e)
        {

            Frm_Modificacion_Equipo_Especial modifEq = new Frm_Modificacion_Equipo_Especial();
            if (TipoEquipo == "especial")
            {
                string[] Pp_codigo_y_cuit_equipo_especial = new string[2];
                Pp_codigo_y_cuit_equipo_especial[0] = grid_equipos.CurrentRow.Cells[0].Value.ToString();
                Pp_codigo_y_cuit_equipo_especial[1] = grid_equipos.CurrentRow.Cells[1].Value.ToString();
                modifEq.TipoEquipo = TipoEquipo;
                modifEq.Pp_codigo_y_cuit_equipo_especial = Pp_codigo_y_cuit_equipo_especial;
            }
            if (TipoEquipo == "simple")
            {
                string[] Pp_codigo_equipo_simple = new string[1];
                Pp_codigo_equipo_simple[0] = grid_equipos.CurrentRow.Cells[0].Value.ToString();
                //NO OLVIDARSE DE ASIGNAR EL PP AL PP DE MODIFICACIONES
                modifEq.TipoEquipo = TipoEquipo;
                modifEq.Pp_codigo_equipo_simple = Pp_codigo_equipo_simple;
            }
            modifEq.ShowDialog();
        }

        private void btn_Eliminar_Equipo_Especial_Click(object sender, EventArgs e)
        {
            Frm_Baja_Equipo_Especial equipoDel = new Frm_Baja_Equipo_Especial();
            if (TipoEquipo == "especial")
            {
                string[] Pp_codigo_y_cuit_equipo_especial = new string[2];
                Pp_codigo_y_cuit_equipo_especial[0] = grid_equipos.CurrentRow.Cells[0].Value.ToString();
                Pp_codigo_y_cuit_equipo_especial[1] = grid_equipos.CurrentRow.Cells[1].Value.ToString();
                equipoDel.TipoEquipo = TipoEquipo;
                equipoDel.Pp_codigo_y_cuit_equipo_especial = Pp_codigo_y_cuit_equipo_especial;
            }
            if(TipoEquipo == "simple")
            {
                string[] Pp_codigo_equipo_simple = new string[1];
                Pp_codigo_equipo_simple[0] = grid_equipos.CurrentRow.Cells[0].Value.ToString();
                //NO OLVIDARSE DE ASIGNAR EL PP AL PP DE MODIFICACIONES
                equipoDel.TipoEquipo = TipoEquipo;
                equipoDel.Pp_codigo_equipo_simple = Pp_codigo_equipo_simple;
            }
            equipoDel.ShowDialog();
        }

        private void Frm_ABMEquipo_Load(object sender, EventArgs e)
        {
            if(TipoEquipo == "simple")
            {
                txt_Cuit_Cliente.Hide();
                label_cuit_cliente.Hide();
                Titulo.Text = "Equipos Simples";
                imagen_equipo_especial.Hide();
                imagen_equipo_simple.Show();

                grid_equipos.Columns.Clear();
                grid_equipos.Formatear("Codigo,100; Precio Mayorista,200; Precio Minorista,200; Nombre,200");
            }
            if(TipoEquipo == "especial")
            {
                txt_Cuit_Cliente.Show();
                label_cuit_cliente.Show();
                imagen_equipo_especial.Show();
                Titulo.Text = "Equipos Especiales";
                imagen_equipo_simple.Hide();

                grid_equipos.Columns.Clear();
                grid_equipos.Formatear("Codigo,100; Cuit del Cliente,125; Descripción,250; Precio,125; Nombre,100");
            }
        }

        private void grid_equipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TipoEquipo == "especial")
            {
                string[] Pp_codigo_y_cuit_equipo_especial = new string[2];
                Pp_codigo_y_cuit_equipo_especial[0] = grid_equipos.CurrentRow.Cells[0].Value.ToString();
                Pp_codigo_y_cuit_equipo_especial[1] = grid_equipos.CurrentRow.Cells[1].Value.ToString();
            }
            if(TipoEquipo == "simple")
            {
                string[] Pp_codigo_equipo = new string[1];
                Pp_codigo_equipo[0] = grid_equipos.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void grid_equipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_Mostrar_Equipo mostrar = new Frm_Mostrar_Equipo();
            if (TipoEquipo == "especial")
            {
                string[] Pp_codigo_y_cuit_equipo_especial = new string[2];
                Pp_codigo_y_cuit_equipo_especial[0] = grid_equipos.CurrentRow.Cells[0].Value.ToString();
                Pp_codigo_y_cuit_equipo_especial[1] = grid_equipos.CurrentRow.Cells[1].Value.ToString();
                mostrar.TipoEquipo = TipoEquipo;
                mostrar.Pp_codigo_y_cuit_equipo_especial = Pp_codigo_y_cuit_equipo_especial;
            }
            if (TipoEquipo == "simple")
            {
                string[] Pp_codigo_equipo_simple = new string[1];
                Pp_codigo_equipo_simple[0] = grid_equipos.CurrentRow.Cells[0].Value.ToString();
                mostrar.TipoEquipo = TipoEquipo;
                mostrar.Pp_codigo_equipo_simple = Pp_codigo_equipo_simple;
            }
            mostrar.ShowDialog();
        }
    }
}
