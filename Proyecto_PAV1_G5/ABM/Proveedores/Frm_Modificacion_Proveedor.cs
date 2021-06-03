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
    public partial class Frm_Modificacion_Proveedor : Form
    {
        public string[] Pp_cuit_proveedores { get; set; }
        NE_Proveedores prov = new NE_Proveedores();

        public Frm_Modificacion_Proveedor()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarDatos(DataTable tabla)
        {
            cmb_barrio.SelectedValue = int.Parse(tabla.Rows[0]["id_barrio"].ToString());
            txt_cuit_proveedor.Text = tabla.Rows[0]["cuit_proveedor"].ToString();
            txt_fechaInicioOperacion.Text = tabla.Rows[0]["fecha_inicio_operacion"].ToString();
            txt_razonSocial.Text = tabla.Rows[0]["razon_social"].ToString();
            txt_calle.Text = tabla.Rows[0]["calle"].ToString();
            txt_nroCalle.Text = tabla.Rows[0]["nro_calle"].ToString();
            txt_telefono.Text = tabla.Rows[0]["telefono"].ToString();
            cmb_empleado.SelectedValue = tabla.Rows[0]["legajo_comprador"].ToString();
        }

        private void Frm_Modificacion_Proveedor_Load(object sender, EventArgs e)
        {
            cmb_barrio.CargarCombo(prov.DatosComboBarrio());
            cmb_empleado.CargarCombo(prov.DatosComboEmpleado());
            MostrarDatos(prov.Recuperar_x_Cuit_Array(Pp_cuit_proveedores));
            cmb_rubro.CargarCombo(prov.DatosComboRubros());
            grid_rubros.Formatear("Id rubro,50; Nombre,100; Descripcion,100");
            grid_rubros.Cargar(prov.RecuperarRubrosProveedor(txt_cuit_proveedor.Text));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            prov.ModificarProveedor(grid_rubros, txt_cuit_proveedor.Text, txt_razonSocial.Text, cmb_empleado.SelectedValue.ToString(), txt_fechaInicioOperacion.Text, txt_fechaInicioOperacion.Text, cmb_barrio.SelectedValue.ToString(), txt_calle.Text, txt_nroCalle.Text);

        }

        private void grid_rubros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar el rubro seleccionado?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grid_rubros.Rows.Remove(grid_rubros.CurrentRow);

            }
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

        private void cmb_rubro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tabla = prov.RecuperarRubrosProveedor(cmb_rubro.SelectedValue.ToString());
            txt_descripcion_rubro.Text = tabla.Rows[0][2].ToString();
        }
    }
}
