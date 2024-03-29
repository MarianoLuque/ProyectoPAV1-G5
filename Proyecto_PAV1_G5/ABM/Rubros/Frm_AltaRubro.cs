﻿using System;
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

namespace Proyecto_PAV1_G5.ABM.Rubros
{
    public partial class Frm_AltaRubro : Form
    {
        public Frm_AltaRubro()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                NE_Rubros rubro = new NE_Rubros();

                rubro.Insertar(this.Controls);
                if (MessageBox.Show("El rubro se registró con éxito", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
