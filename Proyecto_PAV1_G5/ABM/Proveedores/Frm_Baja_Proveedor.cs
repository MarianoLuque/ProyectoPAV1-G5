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
    public partial class Frm_Baja_Proveedor : Form

    {
        public string[] Pp_cuit_proveedores { get; set; }
        NE_Proveedores prov = new NE_Proveedores();

        public Frm_Baja_Proveedor()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Baja_Proveedor_Load(object sender, EventArgs e)
        {
            cmb_barrio.CargarCombo(prov.DatosComboBarrio());
            MostrarDatos(prov.Recuperar_x_Cuit_Array(Pp_cuit_proveedores));
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {

                if (MessageBox.Show("¿Esta seguro de borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    prov.Eliminar(Pp_cuit_proveedores, this.Controls);
                }
                if (MessageBox.Show("El proveedor se eliminó con éxito", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
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
            cmb_barrio.SelectedValue = int.Parse(tabla.Rows[0]["id_barrio"].ToString());
            txt_cuit_proveedor.Text = tabla.Rows[0]["cuit_proveedor"].ToString();
            txt_fechaInicioOperacion.Text = tabla.Rows[0]["fecha_inicio_operacion"].ToString();
            txt_razonSocial.Text = tabla.Rows[0]["razon_social"].ToString();
            txt_calle.Text = tabla.Rows[0]["calle"].ToString();
            txt_nroCalle.Text = tabla.Rows[0]["nro_calle"].ToString();
            txt_telefono.Text = tabla.Rows[0]["telefono"].ToString();
            txt_legajoComprador.Text = tabla.Rows[0]["legajo_comprador"].ToString();
        }
    }
}
