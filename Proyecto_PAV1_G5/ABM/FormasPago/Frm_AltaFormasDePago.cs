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

namespace Proyecto_PAV1_G5.ABM.FormasPago
{
    public partial class Frm_AltaFormasDePago : Form
    {
        // CONSTRUCTOR
        public Frm_AltaFormasDePago()
        {
            InitializeComponent();
        }

        // BOTON CANCELAR
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // BOTON ACEPTAR
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                NE_FormasPago formasP = new NE_FormasPago();


                formasP.Insertar(this.Controls);
                if (MessageBox.Show("La Forma de Pago se registró con éxito", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
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
