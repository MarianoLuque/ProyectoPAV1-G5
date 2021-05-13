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

namespace Proyecto_PAV1_G5.ABM.Proveedores
{
    public partial class Frm_ABMProveedores : Form
    {
        public string[] Pp_cuit_proveedor { get; set; }
        NE_Proveedores prov = new NE_Proveedores();

        public Frm_ABMProveedores()
        {
            InitializeComponent();
        }

        private void CargarGrilla(DataTable tabla)
        {
            //Voy a recorrer la tabla con su contenido para cargar la grilla
            grid_proveedores.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_proveedores.Rows.Add();
                grid_proveedores.Rows[i].Cells[0].Value = tabla.Rows[i]["cuit_proveedor"].ToString();
                grid_proveedores.Rows[i].Cells[1].Value = tabla.Rows[i]["razon_social"].ToString();
                grid_proveedores.Rows[i].Cells[2].Value = tabla.Rows[i]["legajo_comprador"].ToString();
                grid_proveedores.Rows[i].Cells[3].Value = tabla.Rows[i]["fecha_inicio_operacion"].ToString();
                grid_proveedores.Rows[i].Cells[4].Value = tabla.Rows[i]["telefono"].ToString();
                grid_proveedores.Rows[i].Cells[5].Value = tabla.Rows[i]["barrio"].ToString();
                grid_proveedores.Rows[i].Cells[6].Value = tabla.Rows[i]["calle"].ToString();
                grid_proveedores.Rows[i].Cells[7].Value = tabla.Rows[i]["nro_calle"].ToString();
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {

            if (txt_patron_razon_social.Text == "" && txt_patron_cuit.Text == "")
            {
                CargarGrilla(prov.RecuperarTodos());
            }
            if (txt_patron_razon_social.Text != "" && txt_patron_cuit.Text != "")
            {
                CargarGrilla(prov.Recuperar_Mixto(txt_patron_cuit.Text, txt_patron_razon_social.Text));
                return;
            }
            if (txt_patron_razon_social.Text != "")
            {
                CargarGrilla(prov.Recuperar_x_Razon_Social(txt_patron_razon_social.Text));
            }
            if (txt_patron_cuit.Text != "")
            {
                CargarGrilla(prov.Recuperar_x_Cuit(txt_patron_cuit.Text));
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Frm_Alta_Proveedor AltaProv = new Frm_Alta_Proveedor();
            AltaProv.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_Modificacion_Proveedor modifProv = new Frm_Modificacion_Proveedor();
            string[] Pp_cuit_proveedor = new string[1];
            Pp_cuit_proveedor[0] = grid_proveedores.CurrentRow.Cells["cuit_proveedor"].Value.ToString();
            modifProv.Pp_cuit_proveedores = Pp_cuit_proveedor;
            modifProv.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_Baja_Proveedor bajaProv = new Frm_Baja_Proveedor();
            string[] Pp_cuit_proveedor = new string[1];
            Pp_cuit_proveedor[0] = grid_proveedores.CurrentRow.Cells["cuit_proveedor"].Value.ToString();
            bajaProv.Pp_cuit_proveedores = Pp_cuit_proveedor;
            bajaProv.ShowDialog();
        }

        private void grid_proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] Pp_cuit_proveedor = new string[1];
            Pp_cuit_proveedor[0] = grid_proveedores.CurrentRow.Cells["cuit_proveedor"].Value.ToString();
        }
    }
}
