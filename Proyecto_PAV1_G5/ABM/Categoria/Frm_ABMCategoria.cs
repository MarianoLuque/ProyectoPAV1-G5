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

namespace Proyecto_PAV1_G5.ABM.Categoria
{
    public partial class Frm_ABMCategoria : Form
    {
        public string[] Pp_id_categoria { get; set; }
        public Frm_ABMCategoria()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Frm_AltaCategoria altacat = new Frm_AltaCategoria();
            altacat.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_ModificacionCategoria modcat = new Frm_ModificacionCategoria();
            string[] Pp_id_categoria = new string[1];
            Pp_id_categoria[0] = grid_clasificacion.CurrentRow.Cells["id_clasificacion"].Value.ToString();
            modcat.Pp_id_categoria = Pp_id_categoria;
            modcat.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_BajaCategoria bajacat = new Frm_BajaCategoria();
            string[] Pp_id_categoria = new string[1];
            Pp_id_categoria[0] = grid_clasificacion.CurrentRow.Cells["id_clasificacion"].Value.ToString();
            bajacat.Pp_id_categoria = Pp_id_categoria;
            bajacat.ShowDialog();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            NE_Categoria categoria = new NE_Categoria();

            if (txt_cantidad_compras.Text == "" && txt_patron_antiguedad.Text == "")
            {
                CargarGrilla(categoria.RecuperarTodos());
            }
            if (txt_cantidad_compras.Text != "" && txt_patron_antiguedad.Text == "")
            {
                CargarGrilla(categoria.Recuperar_x_cantidad_compras(txt_cantidad_compras.Text));
            }
            if (txt_cantidad_compras.Text == "" && txt_patron_antiguedad.Text != "")
            {
                CargarGrilla(categoria.Recuperar_x_antiguedad(txt_patron_antiguedad.Text));
            }
            if (txt_cantidad_compras.Text != "" && txt_patron_antiguedad.Text != "")
            {
                CargarGrilla(categoria.Recuperar_x_antiguedad_y_cantidad_compras(txt_patron_antiguedad.Text, txt_cantidad_compras.Text));
            }
        }

        private void CargarGrilla(DataTable tabla)
        {
            //Voy a recorrer la tabla con su contenido para cargar la grilla
            grid_clasificacion.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_clasificacion.Rows.Add();
                grid_clasificacion.Rows[i].Cells[0].Value = tabla.Rows[i]["id_clasificacion"].ToString();
                grid_clasificacion.Rows[i].Cells[1].Value = tabla.Rows[i]["anios_antiguedad"].ToString();
                grid_clasificacion.Rows[i].Cells[2].Value = tabla.Rows[i]["cantidad_compras_historicas"].ToString();
                grid_clasificacion.Rows[i].Cells[3].Value = tabla.Rows[i]["descuento"].ToString();
            }
        }

        private void grid_clasificacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] Pp_id_categoria = new string[1];
            Pp_id_categoria[0] = grid_clasificacion.CurrentRow.Cells["id_clasificacion"].Value.ToString();
        }
    }
}
