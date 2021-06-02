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

namespace Proyecto_PAV1_G5.Transacciones.Compras
{
    public partial class Frm_Alta_Compra : Form
    {
        NE_Compras compra = new NE_Compras();
        public Frm_Alta_Compra()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            compra.InsertarCompra(grid_articulos, cmb_proveedor.SelectedValue.ToString());
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_articulos_Click(object sender, EventArgs e)
        {
            if (txt_cantidad.Text == "")
            {
                MessageBox.Show("Falta cargar la cantidad de artículos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_cantidad.Focus();
                return;
            }

            if (cmb_nombre_articulo.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleccionar el artículo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_nombre_articulo.Focus();
                return;
            }

            grid_articulos.Rows.Add(
                                    cmb_nombre_articulo.SelectedValue.ToString()
                                    , cmb_nombre_articulo.Text
                                    , cmb_rubro.SelectedValue.ToString()
                                    , cmb_rubro.Text
                                    , txt_cantidad.Text);

            cmb_nombre_articulo.SelectedIndex = -1;
            cmb_rubro.SelectedIndex = -1;
            txt_descripcion_articulo.Text = "";
            txt_cantidad.Text = "";
        }

        private void Frm_Alta_Compra_Load(object sender, EventArgs e)
        {
            grid_articulos.Formatear("Codigo,75; Nombre,200; Id Rubro,75; Rubro Articulo,150; Cantidad,100");
            cmb_proveedor.CargarCombo(compra.DatosComboProveedor());
        }

        private void cmb_proveedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_rubro.Enabled = true;
            cmb_rubro.CargarCombo(compra.DatosComboRubro(cmb_proveedor.SelectedValue.ToString()));
        }

        private void cmb_rubro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_nombre_articulo.Enabled = true;
            cmb_nombre_articulo.CargarCombo(compra.DatosComboArticulo(cmb_rubro.SelectedValue.ToString(), cmb_proveedor.SelectedValue.ToString()));
        }

        private void cmb_nombre_articulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tabla = compra.RecuperarArticulo(cmb_nombre_articulo.SelectedValue.ToString());
            txt_descripcion_articulo.Text = tabla.Rows[0][2].ToString();
        }
    }
}
