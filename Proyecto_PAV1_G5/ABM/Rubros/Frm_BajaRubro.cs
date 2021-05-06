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
    public partial class Frm_BajaRubro : Form
    {
        public string[] Pp_id_rubro { get; set; }
        NE_Rubros rubros = new NE_Rubros();
        public Frm_BajaRubro()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {

                if (MessageBox.Show("¿Esta seguro de borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    rubros.Eliminar(Pp_id_rubro, this.Controls);
                }
                if (MessageBox.Show("El rubro se eliminó con éxito", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
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

        private void MostrarDatos(DataTable tabla)
        {
            txt_id_rubro.Text = tabla.Rows[0]["id_rubro"].ToString();
            txt_nombre_rubro.Text = tabla.Rows[0]["nombre_rubro"].ToString();
            txt_descripcion.Text = tabla.Rows[0]["descripcion"].ToString();

        }

        private void Frm_BajaRubro_Load(object sender, EventArgs e)
        {
            MostrarDatos(rubros.Recuperar_x_Id_Rubro_Array(Pp_id_rubro));
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
