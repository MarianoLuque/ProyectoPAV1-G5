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

namespace Proyecto_PAV1_G5.ABM.Equipos.Equipos_Simples
{
    public partial class Frm_Modificacion_Equipo_Simple : Form
    {
        public string[] Pp_codigo_equipo { get; set; }
        NE_Equipos_Simples equipo = new NE_Equipos_Simples();
        public Frm_Modificacion_Equipo_Simple()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {

                equipo.Modificar(Pp_codigo_equipo, this.Controls);
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_codigo_equipo.Text = tabla.Rows[0]["codigo_equipo"].ToString();
            txt_Precio_Mayorista.Text = tabla.Rows[0]["precio_mayorista"].ToString();
            txt_Precio_Minorista.Text = tabla.Rows[0]["precio_minorista"].ToString();
            txt_Nombre_Equipo.Text = tabla.Rows[0]["nombre_equipo"].ToString();
        }

        private void Frm_Modificacion_Equipo_Simple_Load(object sender, EventArgs e)
        {
            MostrarDatos(equipo.Recuperar_x_Codigo_Array(Pp_codigo_equipo));
        }
    }
}
