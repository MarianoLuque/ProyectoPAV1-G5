using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAV1_G5.Clases;
using Proyecto_PAV1_G5.Negocios;

namespace Proyecto_PAV1_G5.ABM.Rubros
{
    public partial class Frm_ModificacionRubro : Form
    {
        public string[] Pp_id_rubro { get; set; }
        NE_Rubros rubro = new NE_Rubros();
        public Frm_ModificacionRubro()
        {
            InitializeComponent();
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_id_rubro.Text = tabla.Rows[0]["id_rubro"].ToString();
            txt_nombre_rubro.Text = tabla.Rows[0]["nombre_rubro"].ToString();
            txt_descripcion.Text = tabla.Rows[0]["descripcion"].ToString();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {

                rubro.Modificar(Pp_id_rubro, this.Controls);
                if (MessageBox.Show("El rubro se modificó con éxito", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ModificacionRubro_Load_1(object sender, EventArgs e)
        {
            MostrarDatos(rubro.Recuperar_x_Id_Rubro_Array(Pp_id_rubro));
        }

    }
}
