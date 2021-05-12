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
    public partial class Frm_Baja_Equipo_Especial : Form
    {
        public string[] Pp_codigo_y_cuit_equipo_especial { get; set; }

        NE_EquiposEspeciales equipo = new NE_EquiposEspeciales();
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        Acceso_Datos _BD = new Acceso_Datos();

        public Frm_Baja_Equipo_Especial()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                NE_EquiposEspeciales equipo = new NE_EquiposEspeciales();
                if (MessageBox.Show("¿Está seguro que desea eliminar el equipo?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    equipo.Eliminar(Pp_codigo_y_cuit_equipo_especial, this.Controls);
                    if (MessageBox.Show("El equipo se eliminó correctamente", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }

            }
            else
            {
                return;
            }
       
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void MostrarDatos(DataTable tabla)
        {
            txt_Codigo_Equipo_Especial.Text = tabla.Rows[0]["codigo_equipo_especial"].ToString();
            txt_Cuit_Cliente_Equipo_Especial.Text = tabla.Rows[0]["cuit_cliente"].ToString();
            txt_Descripcion_Equipo_Especial.Text = tabla.Rows[0]["descripcion"].ToString();
            txt_Precio_Equipo_Especial.Text = tabla.Rows[0]["precio"].ToString();
            txt_Nombre_Equipo_Especial.Text = tabla.Rows[0]["nombre_equipo_especial"].ToString();
        }

        private void Frm_Baja_Equipo_Especial_Load(object sender, EventArgs e)
        {
            MostrarDatos(equipo.Recuperar_x_Codigo_y_Cuit_Array(Pp_codigo_y_cuit_equipo_especial));
        }
    }
}
