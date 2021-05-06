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

namespace Proyecto_PAV1_G5.ABM.Clientes
{
    public partial class Frm_ABMClientes : Form
    {
        public string[] Pp_cuit_clientes { get; set; }
        public Frm_ABMClientes()
        {
            InitializeComponent();
        }

        private void btn_AltaCliente_Click(object sender, EventArgs e)
        {
            Frm_AltaCliente altaCliente = new Frm_AltaCliente();
            altaCliente.ShowDialog();
        }

        private void btn_ModificarCliente_Click(object sender, EventArgs e)
        {
            Frm_ModificacionCliente modifCliente = new Frm_ModificacionCliente();
            string[] Pp_cuit_clientes = new string[1];
            Pp_cuit_clientes[0] = grid_Clientes.CurrentRow.Cells["Cuit"].Value.ToString();
            modifCliente.Pp_cuit_clientes = Pp_cuit_clientes;
            modifCliente.ShowDialog();
        }

        private void btn_EliminarCliente_Click(object sender, EventArgs e)
        {
            Frm_BajaCliente bajaCliente = new Frm_BajaCliente();
            string[] Pp_cuit_clientes = new string[1];
            Pp_cuit_clientes[0] = grid_Clientes.CurrentRow.Cells["Cuit"].Value.ToString();
            bajaCliente.Pp_cuit_clientes = Pp_cuit_clientes;
            bajaCliente.ShowDialog();
        }

        private void Frm_ABMClientes_Load(object sender, EventArgs e)
        {

        }

        private void CargarGrilla(DataTable tabla)
        {
            //Voy a recorrer la tabla con su contenido para cargar la grilla
            grid_Clientes.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_Clientes.Rows.Add();
                grid_Clientes.Rows[i].Cells[0].Value = tabla.Rows[i]["cuit_clientes"].ToString();
                grid_Clientes.Rows[i].Cells[1].Value = tabla.Rows[i]["razon_social"].ToString();
                grid_Clientes.Rows[i].Cells[2].Value = tabla.Rows[i]["nombre_contacto"].ToString();
                grid_Clientes.Rows[i].Cells[3].Value = tabla.Rows[i]["credito_limite"].ToString();
                grid_Clientes.Rows[i].Cells[4].Value = tabla.Rows[i]["id_clasificacion"].ToString();
                grid_Clientes.Rows[i].Cells[5].Value = tabla.Rows[i]["fecha_primera_compra"].ToString();
                grid_Clientes.Rows[i].Cells[6].Value = tabla.Rows[i]["cantidad_compras_historicas"].ToString();
                grid_Clientes.Rows[i].Cells[7].Value = tabla.Rows[i]["barrio"].ToString();
                grid_Clientes.Rows[i].Cells[8].Value = tabla.Rows[i]["calle"].ToString();
                grid_Clientes.Rows[i].Cells[9].Value = tabla.Rows[i]["nro_calle"].ToString();
                grid_Clientes.Rows[i].Cells[10].Value = tabla.Rows[i]["vendedor_asignado"].ToString();
            }

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            NE_Clientes cli = new NE_Clientes();

            if (txt_patron_razon_social.Text == "" && txt_patron_cuit.Text == "")
            {
                CargarGrilla(cli.RecuperarTodos());
            }
            if (txt_patron_razon_social.Text != "" && txt_patron_cuit.Text != "")
            {
                CargarGrilla(cli.Recuperar_Mixto(txt_patron_cuit.Text, txt_patron_razon_social.Text));
                return;
            }
            if (txt_patron_razon_social.Text != "")
            {
                CargarGrilla(cli.Recuperar_x_Razon_Social(txt_patron_razon_social.Text));
            }
            if (txt_patron_cuit.Text != "")
            {
                CargarGrilla(cli.Recuperar_x_Cuit(txt_patron_cuit.Text));
            }
        }

        private void grid_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] Pp_cuit_clientes = new string[1];
            Pp_cuit_clientes[0] = grid_Clientes.CurrentRow.Cells["Cuit"].Value.ToString();
        }
    }
}
