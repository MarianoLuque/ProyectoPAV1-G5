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
    public partial class Frm_BajaArticulo : Form
    {
        public string[] Pp_codigo_articulo { get; set; }
        NE_Articulos articulo = new NE_Articulos();
        public Frm_BajaArticulo()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_BajaArticulo_Load(object sender, EventArgs e)
        {
            cmb_pais.CargarCombo(articulo.DatosComboPais());
            MostrarDatos(articulo.RecuperarCodigo(Pp_codigo_articulo));
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_codigo_articulo.Text = tabla.Rows[0]["codigo_articulo"].ToString();
            cmb_pais.SelectedValue = int.Parse(tabla.Rows[0]["id_pais"].ToString());
            txt_nombre.Text = tabla.Rows[0]["nombre_articulo"].ToString();
            txt_descripcion.Text = tabla.Rows[0]["descripcion"].ToString();
            txt_stock.Text = tabla.Rows[0]["cantidad_stock"].ToString();
            txt_costomay.Text = tabla.Rows[0]["costo_mayorista"].ToString();
            txt_costomin.Text = tabla.Rows[0]["costo_minorista"].ToString();
            txt_cuit.Text = tabla.Rows[0]["cuit_proveedor"].ToString();
            txt_envio.Text = tabla.Rows[0]["tiempo_envio"].ToString();
            txt_plazopago.Text = tabla.Rows[0]["plazo_pago"].ToString();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                NE_Articulos art = new NE_Articulos();
                if (MessageBox.Show("¿Está seguro que desea eliminar el artículo?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    art.Eliminar(Pp_codigo_articulo, this.Controls);
                    if (MessageBox.Show("El artículo se eliminó correctamente", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }

            }
            else
            {
                return;
            }
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
