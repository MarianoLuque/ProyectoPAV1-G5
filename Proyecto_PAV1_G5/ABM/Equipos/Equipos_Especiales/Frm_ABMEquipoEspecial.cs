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
    public partial class Frm_ABMEquipoEspecial : Form
    {
        public string[] Pp_codigo_equipo_especial { get; set; }
        NE_EquiposEspeciales equipoEs = new NE_EquiposEspeciales();
        Acceso_Datos _BD = new Acceso_Datos();
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();



        public Frm_ABMEquipoEspecial()
        {
            InitializeComponent();
        }

        //BOTON AGREGAR
        private void btn_Agregar_Equipo_Especial_Click(object sender, EventArgs e)
        {
            Frm_Alta_Equipo_Especial altaEqEsp = new Frm_Alta_Equipo_Especial();
            altaEqEsp.ShowDialog();
        }

        //CARGAR GRILLA
        private void CargarGrilla(DataTable tabla)
        {
            grid_Equipo_Especial.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_Equipo_Especial.Rows.Add();
                grid_Equipo_Especial.Rows[i].Cells[0].Value = tabla.Rows[i]["codigo_equipo_especial"].ToString();
                grid_Equipo_Especial.Rows[i].Cells[1].Value = tabla.Rows[i]["cuit_cliente"].ToString();
                grid_Equipo_Especial.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion"].ToString();
                grid_Equipo_Especial.Rows[i].Cells[3].Value = tabla.Rows[i]["precio"].ToString();
                grid_Equipo_Especial.Rows[i].Cells[4].Value = tabla.Rows[i]["nombre_equipo_especial"].ToString();
            }

        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            grid_Equipo_Especial.Rows.Clear();

            if (txt_Codigo_Equipo_Especial.Text == "" && txt_Nombre_Equipo_Especial.Text == "" && txt_Cuit_Cliente.Text == "")
            {
                CargarGrilla(equipoEs.RecuperarTodos());
            }
            if (txt_Codigo_Equipo_Especial.Text == "" && txt_Nombre_Equipo_Especial.Text == "")
            {
                CargarGrilla(equipoEs.Recuperar_Cuit_Cliente(txt_Cuit_Cliente.Text));
                return;
            }
            if (txt_Cuit_Cliente.Text ==  "" && txt_Nombre_Equipo_Especial.Text == "")
            {
                CargarGrilla(equipoEs.Recuperar_x_Codigo_Equipo(txt_Codigo_Equipo_Especial.Text));
            }
            if (txt_Cuit_Cliente.Text == "" && txt_Codigo_Equipo_Especial.Text == "")
            {
                CargarGrilla(equipoEs.Recuperar_x_Nombre(txt_Nombre_Equipo_Especial.Text));
            }
        }


            private void btn_Modificar_Equipo_Especial_Click(object sender, EventArgs e)
        {
            Frm_Modificacion_Equipo_Especial modifEq = new Frm_Modificacion_Equipo_Especial();
            string[] Pp_codigo_equipo_especial = new string[2];
            Pp_codigo_equipo_especial[0] = grid_Equipo_Especial.CurrentRow.Cells["codigo_equipo_especial"].Value.ToString();
            Pp_codigo_equipo_especial[1] = grid_Equipo_Especial.CurrentRow.Cells["cuit_cliente"].Value.ToString();
            modifEq.Pp_codigo_equipo_especial = Pp_codigo_equipo_especial;
            modifEq.ShowDialog();
        }

        private void btn_Eliminar_Equipo_Especial_Click(object sender, EventArgs e)
        {
            Frm_Baja_Equipo_Especial equipoDel = new Frm_Baja_Equipo_Especial();
            string[] Pp_codigo_equipo_especial = new string[2];
            Pp_codigo_equipo_especial[0] = grid_Equipo_Especial.CurrentRow.Cells["codigo_equipo_especial"].Value.ToString();
            Pp_codigo_equipo_especial[1] = grid_Equipo_Especial.CurrentRow.Cells["cuit_cliente"].Value.ToString();
            equipoDel.Pp_codigo_equipo_especial = Pp_codigo_equipo_especial;
            equipoDel.ShowDialog();
        }

    }
}
