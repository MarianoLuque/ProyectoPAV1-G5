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

namespace Proyecto_PAV1_G5.ABM.Articulos
{
    public partial class Frm_AltaArticulo : Form
    {
        NE_Articulos articulo = new NE_Articulos();
        public Frm_AltaArticulo()
        {
            InitializeComponent();
        }

        private void Frm_AltaCliente_Load(object sender, EventArgs e)
        {
            cmb_pais.CargarCombo(articulo.DatosCombo());
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                NE_Articulos articulo = new NE_Articulos();


                articulo.Insertar(this.Controls);
                if (MessageBox.Show("El artículo se registró con éxito", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
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
