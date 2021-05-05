using System;
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

namespace Proyecto_PAV1_G5.ABM.Clientes
{
    public partial class Frm_ModificacionCliente : Form
    {
        public string[] Pp_cuit_clientes { get; set; }
        NE_Clientes cli = new NE_Clientes();
        public Frm_ModificacionCliente()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                NE_Clientes cliente = new NE_Clientes();


                cliente.Modificar(Pp_cuit_clientes, this.Controls);
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ModificacionCliente_Load(object sender, EventArgs e)
        {
            cmb_barrios.CargarCombo(cli.DatosCombo());
            MostrarDatos(cli.Recuperar_x_Cuit_Array(Pp_cuit_clientes));
        }

        private void MostrarDatos(DataTable tabla)
        {
            cmb_barrios.SelectedValue = int.Parse(tabla.Rows[0]["id_barrio"].ToString());
            txt_cuit.Text = tabla.Rows[0]["cuit_clientes"].ToString();
            txt_nombre_contacto.Text = tabla.Rows[0]["nombre_contacto"].ToString();
            txt_razon_social.Text = tabla.Rows[0]["razon_social"].ToString();
            txt_calle.Text = tabla.Rows[0]["calle"].ToString();
            txt_numero_calle.Text = tabla.Rows[0]["nro_calle"].ToString();
            txt_credito_limite.Text = tabla.Rows[0]["credito_limite"].ToString();
            txt_legajo_vendedor.Text = tabla.Rows[0]["legajo_vendedor_asignado"].ToString();
        }

    }
}
