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

                prov.Insertar(this.Controls);
                if (MessageBox.Show("El proveedor se registró con éxito", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }

        private void Frm_Alta_Proveedor_Load(object sender, EventArgs e)
        {
            cmb_barrio.CargarCombo(prov.DatosComboBarrio());
        }
    }
}
