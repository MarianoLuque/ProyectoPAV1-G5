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
    public partial class Frm_ModificacionArticulo : Form
    {
        public string[] Pp_codigo_articulo { get; set; }
        NE_Articulos art = new NE_Articulos();
        public Frm_ModificacionArticulo()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                NE_Articulos articulo = new NE_Articulos();


                articulo.Modificar(Pp_codigo_articulo, this.Controls);
                if (MessageBox.Show("El cliente se modificó con éxito", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }

        private void Frm_ModificacionCliente_Load(object sender, EventArgs e)
        {
            cmb_pais.CargarCombo(art.DatosCombo());
            MostrarDatos(art.RecuperarCodigo(Pp_codigo_articulo));
        }

        private void MostrarDatos(DataTable tabla)
        {
            cmb_pais.SelectedValue = int.Parse(tabla.Rows[0]["id_pais"].ToString());
            txt_nombre.Text = tabla.Rows[0]["nombre_articulo"].ToString();
            txt_stock.Text = tabla.Rows[0]["cantidad_stock"].ToString();
            txt_costomay.Text = tabla.Rows[0]["costo_mayorista"].ToString();
            txt_costomin.Text = tabla.Rows[0]["costo_minorista"].ToString();
            txt_cuit.Text = tabla.Rows[0]["cuit_proveedor"].ToString();
            txt_envio.Text = tabla.Rows[0]["tiempo_envio"].ToString();
            txt_plazopago.Text = tabla.Rows[0]["plazo_pago"].ToString();
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
