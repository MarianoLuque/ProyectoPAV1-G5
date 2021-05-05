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

namespace Proyecto_PAV1_G5.ABM.Clientes
{
    public partial class Frm_AltaCliente : Form
    {
        NE_Clientes cli = new NE_Clientes();
        public Frm_AltaCliente()
        {
            InitializeComponent();
        }

        private void Frm_AltaCliente_Load(object sender, EventArgs e)
        {
            cmb_barrios.CargarCombo(cli.DatosCombo());
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
                NE_Clientes cliente = new NE_Clientes();


                cliente.Insertar(this.Controls);
                if (MessageBox.Show("El cliente se registró con éxito", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }
    }
}
