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
    public partial class Frm_Modificacion_Equipo_Especial : Form
    {
        public string[] Pp_codigo_y_cuit_equipo_especial;
        NE_EquiposEspeciales equipoEs = new NE_EquiposEspeciales();
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();


        public Frm_Modificacion_Equipo_Especial()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            { 
                equipoEs.Modificar(Pp_codigo_y_cuit_equipo_especial, this.Controls);
                if (MessageBox.Show("El equipo se modificó con éxito", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_Codigo_Equipo_Especial.Text = tabla.Rows[0]["codigo_equipo_especial"].ToString();
            txt_Cuit_Cliente_Equipo_Especial.Text = tabla.Rows[0]["cuit_cliente"].ToString();
            txt_Descripcion_Equipo_Especial.Text = tabla.Rows[0]["descripcion"].ToString();
            txt_Precio_Equipo_Especial.Text = tabla.Rows[0]["precio"].ToString();
            txt_Nombre_Equipo_Especial.Text = tabla.Rows[0]["nombre_equipo_especial"].ToString();
        }

        private void Frm_Modificacion_Equipo_Especial_Load_1(object sender, EventArgs e)
        {
            MostrarDatos(equipoEs.Recuperar_x_Codigo_y_Cuit_Array(Pp_codigo_y_cuit_equipo_especial));
        }
    }
}
