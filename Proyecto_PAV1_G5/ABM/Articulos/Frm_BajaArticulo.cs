using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAV1_G5.ABM.Articulos
{
    public partial class Frm_BajaArticulo : Form
    {
        public Frm_BajaArticulo()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea eliminar el artículo?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)==DialogResult.OK)
            {
                if (MessageBox.Show("El artículo se eliminó correctamente", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
