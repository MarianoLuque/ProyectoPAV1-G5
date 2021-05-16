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


namespace Proyecto_PAV1_G5.ABM.FormasPago
{
    public partial class Frm_ABMFormasPago : Form
    {
        // ZONA DE DECLARACIONES
        public string[] Pp_id_forma_pago { get; set; }

        // CONSTRUCTOR
        public Frm_ABMFormasPago()
        {
            InitializeComponent();
        }

        // PARA CARGAR LA GRILLA
        private void CargarGrilla(DataTable tabla)
        {
            //Voy a recorrer la tabla con su contenido para cargar la grilla
            grid_forma_pago.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_forma_pago.Rows.Add();
                grid_forma_pago.Rows[i].Cells[0].Value = tabla.Rows[i]["id_forma_pago"].ToString();
                grid_forma_pago.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre_forma_pago"].ToString();
                grid_forma_pago.Rows[i].Cells[2].Value = tabla.Rows[i]["interes"].ToString();
                grid_forma_pago.Rows[i].Cells[3].Value = tabla.Rows[i]["descuento"].ToString();
            }
        }

        // PARA CUANDO HAGO CLICK EN UNA FILA, ME TOME EL ID
        private void grid_forma_pago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] Pp_id_forma_pago = new string[1];
            Pp_id_forma_pago[0] = grid_forma_pago.CurrentRow.Cells["id_forma_pago"].Value.ToString();
        }

        // PARA VER QUE RECUPERO CON EL CONSULTAR
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            NE_FormasPago forma_pago = new NE_FormasPago();

            if (txt_patron_nombre_forma_pago.Text == "" )
            {
                CargarGrilla(forma_pago.RecuperarTodos());
            }
            if (txt_patron_nombre_forma_pago.Text != "")
            {
                CargarGrilla(forma_pago.Recuperar_x_nombre(txt_patron_nombre_forma_pago.Text));
            }
        }

        // BOTON AGREGAR
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Frm_AltaFormasDePago altafp = new Frm_AltaFormasDePago();
            altafp.ShowDialog();
        }

        // BOTON MODIFICAR
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_ModificacionFormaPago modfp = new Frm_ModificacionFormaPago();
            string[] Pp_id_forma_pago = new string[1];
            Pp_id_forma_pago[0] = grid_forma_pago.CurrentRow.Cells["id_forma_pago"].Value.ToString();
            modfp.Pp_id_forma_pago = Pp_id_forma_pago;
            modfp.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_BajaFormaPago bajafp = new Frm_BajaFormaPago();
            string[] Pp_id_forma_pago = new string[1];
            Pp_id_forma_pago[0] = grid_forma_pago.CurrentRow.Cells["id_forma_pago"].Value.ToString();
            bajafp.Pp_id_forma_pago = Pp_id_forma_pago;
            bajafp.ShowDialog();
        }
    }
}
