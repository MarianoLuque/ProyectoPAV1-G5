using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAV1_G5.ABM.Clientes
{
    public partial class Frm_ABMClientes : Form
    {
        public Frm_ABMClientes()
        {
            InitializeComponent();
        }

        private void btn_AltaCliente_Click(object sender, EventArgs e)
        {
            Frm_AltaCliente altaCliente = new Frm_AltaCliente();
            altaCliente.ShowDialog();
        }

        private void btn_ModificarCliente_Click(object sender, EventArgs e)
        {
            Frm_ModificacionCliente modifCliente = new Frm_ModificacionCliente();
            modifCliente.ShowDialog();
        }

        private void btn_EliminarCliente_Click(object sender, EventArgs e)
        {
            Frm_BajaCliente bajaCliente = new Frm_BajaCliente();
            bajaCliente.ShowDialog();
        }

    }
}
