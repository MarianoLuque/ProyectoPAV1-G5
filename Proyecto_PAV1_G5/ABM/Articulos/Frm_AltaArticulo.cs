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

namespace Proyecto_PAV1_G5.ABM.Articulos
{
    public partial class Frm_AltaArticulo : Form
    {
        NE_Articulos articulo = new NE_Articulos();
        public Frm_AltaArticulo()
        {
            InitializeComponent();
        }

        private void Frm_AltaArticulo_Load_1(object sender, EventArgs e)
        {
            cmb_pais.CargarCombo(articulo.DatosComboPais());
            cmb_proveedor.CargarCombo(articulo.DatosComboProveedor());
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                NE_Articulos articulo = new NE_Articulos();
                articulo.InsertarArticulo(txt_nombre.Text, txt_descripcion.Text, txt_stock.Text, txt_costomay.Text, txt_costomin.Text, cmb_pais.SelectedValue.ToString(), cmb_proveedor.SelectedValue.ToString(), cmb_rubros.SelectedValue.ToString(), txt_envio.Text, txt_plazopago.Text);
            }
            else
            {
                return;
            }
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_proveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_rubros.Enabled = true;
            cmb_rubros.CargarCombo(articulo.DatosComboRubro(cmb_proveedor.SelectedValue.ToString()));
        }
    }
}
