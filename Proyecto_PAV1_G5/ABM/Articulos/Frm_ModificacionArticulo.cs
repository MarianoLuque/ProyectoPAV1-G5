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
    public partial class Frm_ModificacionArticulo : Form
    {
        public Frm_ModificacionArticulo()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar los cambios en el artículo?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)==DialogResult.OK)
            {
                if (MessageBox.Show("El artículo se modificó correctamente", "Aviso", MessageBoxButtons.OK)==DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
