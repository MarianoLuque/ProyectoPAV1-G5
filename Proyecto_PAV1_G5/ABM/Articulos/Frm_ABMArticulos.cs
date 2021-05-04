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
    public partial class Frm_ABMArticulos : Form
    {
        public Frm_ABMArticulos()
        {
            InitializeComponent();
        }

        private void btn_altaarticulo_Click(object sender, EventArgs e)
        {
            Frm_AltaArticulo altaArt = new Frm_AltaArticulo();
            altaArt.ShowDialog();
        }

        private void btn_modificararticulo_Click(object sender, EventArgs e)
        {
            Frm_ModificacionArticulo modifArt = new Frm_ModificacionArticulo();
            modifArt.ShowDialog();
        }

        private void btn_bajaarticulo_Click(object sender, EventArgs e)
        {
            Frm_BajaArticulo bajaArt = new Frm_BajaArticulo();
            bajaArt.ShowDialog();
        }
    }
}
