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

namespace Proyecto_PAV1_G5.ABM.Equipos.Equipos_Simples
{
    public partial class Frm_Alta_Equipo_Simple : Form
    {
        // ZONA DE DECLARACIONES
        NE_Equipos_Simples equipos = new NE_Equipos_Simples();

        // CONSTRUCTOR
        public Frm_Alta_Equipo_Simple()
        {
            InitializeComponent();
        }

        // BOTON ACEPTAR INSERTAR
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                equipos.Insertar(this.Controls);
                if (MessageBox.Show("El equipo se agrego con éxito", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }

        // BOTON CANCELAR
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}