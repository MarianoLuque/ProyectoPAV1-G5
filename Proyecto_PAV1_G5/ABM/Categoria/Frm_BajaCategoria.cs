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

namespace Proyecto_PAV1_G5.ABM.Categoria
{
    public partial class Frm_BajaCategoria : Form
    {
        public string[] Pp_id_categoria { get; set; }
        NE_Categoria categoria = new NE_Categoria();
        public Frm_BajaCategoria()
        {
            InitializeComponent();
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {

                if (MessageBox.Show("¿Esta seguro de borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    categoria.Eliminar(Pp_id_categoria, this.Controls);
                }
                if (MessageBox.Show("La categoria se eliminó con éxito", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
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
            txt_antiguedad.Text = tabla.Rows[0]["anios_antiguedad"].ToString();
            txt_cantidad_compras.Text = tabla.Rows[0]["cantidad_compras_historicas"].ToString();
            txt_descuento.Text = tabla.Rows[0]["descuento"].ToString();
        }

        private void Frm_BajaCategoria_Load(object sender, EventArgs e)
        {
            MostrarDatos(categoria.Recuperar_x_ID_Categoria_Array(Pp_id_categoria));
        }
    }
}
