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
    public partial class Frm_ModificacionCliente : Form
    {
        NE_Clientes cli = new NE_Clientes();
        public Frm_ModificacionCliente()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ModificacionCliente_Load(object sender, EventArgs e)
        {
            cmb_barrios.CargarCombo(cli.DatosCombo());
        }
    }
}
