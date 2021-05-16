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

namespace Proyecto_PAV1_G5.ABM.FormasPago
{
    public partial class Frm_BajaFormaPago : Form
    {
        // ZONA DE DECLARACIONES
        public string[] Pp_id_forma_pago { get; set; }
        NE_FormasPago formaP = new NE_FormasPago();

        // CONSTRUCTOR
        public Frm_BajaFormaPago()
        {
            InitializeComponent();
        }

        // BOTON CANCELAR
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // RECUPERA LOS DATOS DE ESA FORMA DE PAGO ESPECIFICA
        private void Frm_BajaFormaPago_Load(object sender, EventArgs e)
        {
            MostrarDatos(formaP.Recuperar_x_ID_Forma_Pago_Array(Pp_id_forma_pago));
        }

        // MOSTRAR DATOS
        private void MostrarDatos(DataTable tabla)
        {
            txt_id_forma_pago.Text = tabla.Rows[0]["id_forma_pago"].ToString();
            txt_nombre_forma_pago.Text = tabla.Rows[0]["nombre_forma_pago"].ToString();
            txt_interes.Text = tabla.Rows[0]["interes"].ToString();
            txt_descuento.Text = tabla.Rows[0]["descuento"].ToString();
        }

        // BOTON ACEPTAR
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {

                if (MessageBox.Show("¿Esta seguro de borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    formaP.Eliminar(Pp_id_forma_pago, this.Controls);
                }
                if (MessageBox.Show("La Forma de Pago se eliminó con éxito", "Aviso", MessageBoxButtons.OK) == DialogResult.OK)
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
