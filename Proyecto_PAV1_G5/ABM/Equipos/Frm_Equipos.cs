using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAV1_G5.ABM.Equipos.Equipos_Simples;
using Proyecto_PAV1_G5.ABM.Equipos.Equipos_Especiales;

namespace Proyecto_PAV1_G5.ABM.Equipos
{
    public partial class Frm_Equipos : Form
    {
        public Frm_Equipos()
        {
            InitializeComponent();
        }
        
        private void btn_equiposimple_Click(object sender, EventArgs e)
        {
            Frm_ABMEquipoSimple equiposimple = new Frm_ABMEquipoSimple();
            equiposimple.ShowDialog();
        }

        private void btn_equipoespecial_Click(object sender, EventArgs e)
        {
            Frm_ABMEquipoEspecial equipoespecial = new Frm_ABMEquipoEspecial();
            equipoespecial.ShowDialog();
        }
    }
}
