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

namespace Proyecto_PAV1_G5.ABM.Proveedores
{
    public partial class Frm_Alta_Proveedor : Form
    {
        NE_Proveedores prov = new NE_Proveedores();
        NE_Rubros rub = new NE_Rubros();
        public Frm_Alta_Proveedor()
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

                prov.InsertarProveedor(grid_rubros, txt_cuit_proveedor.Text, txt_razonSocial.Text, cmb_LegajoComprador.SelectedValue.ToString(), txt_fechaInicioOperacion.Text, txt_telefono.Text, cmb_barrio.SelectedValue.ToString(), txt_calle.Text, txt_nroCalle.Text);
            }
            else
            {
                return;
            }
            this.Close();
        }

        private void Frm_Alta_Proveedor_Load(object sender, EventArgs e)
        {
            cmb_barrio.CargarCombo(prov.DatosComboBarrio());
            cmb_rubro.CargarCombo(prov.DatosComboRubros());
            grid_rubros.Formatear("Id rubro,50; Nombre,100; Descripcion,100");
            cmb_LegajoComprador.CargarCombo(prov.DatosComboEmpleado());

        }

        private void btn_Agregar_rubro_Click(object sender, EventArgs e)
        {
            if (cmb_rubro.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleccionar el rubro", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_rubro.Focus();
                return;
            }

            grid_rubros.Rows.Add(
                                    cmb_rubro.SelectedValue.ToString()
                                    , cmb_rubro.Text
                                    , txt_descripcion_rubro.Text);
        }

        private void cmb_rubros_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tabla = rub.RecuperarRubro(cmb_rubro.SelectedValue.ToString());
            txt_descripcion_rubro.Text = tabla.Rows[0][2].ToString();
        }

        private void grid_rubros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar el rubro seleccionado?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grid_rubros.Rows.Remove(grid_rubros.CurrentRow);

            }
        }
    }
}
