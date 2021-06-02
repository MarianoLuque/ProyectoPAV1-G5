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

namespace Proyecto_PAV1_G5.ABM.Articulos
{
    public partial class Frm_ABMArticulos : Form
    {
        public string[] Pp_codigo_articulo { get; set; }
        public Frm_ABMArticulos()
        {
            InitializeComponent();
        }

        private void btn_altaarticulo_Click(object sender, EventArgs e)
        {
            Frm_AltaArticulo altaArt = new Frm_AltaArticulo();
            altaArt.ShowDialog();
        }

        private void CargarGrilla(DataTable tabla)
        {
            //Voy a recorrer la tabla con su contenido para cargar la grilla
            grid_articulos.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_articulos.Rows.Add();
                grid_articulos.Rows[i].Cells[0].Value = tabla.Rows[i]["codigo_articulo"].ToString();
                grid_articulos.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre_articulo"].ToString();
                grid_articulos.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion"].ToString();
                grid_articulos.Rows[i].Cells[3].Value = tabla.Rows[i]["cantidad_stock"].ToString();
                grid_articulos.Rows[i].Cells[4].Value = tabla.Rows[i]["costo_mayorista"].ToString();
                grid_articulos.Rows[i].Cells[5].Value = tabla.Rows[i]["costo_minorista"].ToString();
                grid_articulos.Rows[i].Cells[6].Value = tabla.Rows[i]["razon_social"].ToString();
                grid_articulos.Rows[i].Cells[7].Value = tabla.Rows[i]["nombre_rubro"].ToString();
            }

        }

        private void btn_modificararticulo_Click(object sender, EventArgs e)
        {
            Frm_ModificacionArticulo modifArt = new Frm_ModificacionArticulo();
            string[] Pp_codigo_articulo = new string[1];
            Pp_codigo_articulo[0] = grid_articulos.CurrentRow.Cells["Codigo"].Value.ToString();
            modifArt.Pp_codigo_articulo = Pp_codigo_articulo;
            modifArt.ShowDialog();
        }

        private void btn_bajaarticulo_Click(object sender, EventArgs e)
        {
            Frm_BajaArticulo bajaArt = new Frm_BajaArticulo();
            string[] Pp_codigo_articulo = new string[1];
            Pp_codigo_articulo[0] = grid_articulos.CurrentRow.Cells["Codigo"].Value.ToString();
            bajaArt.Pp_codigo_articulo = Pp_codigo_articulo;
            bajaArt.ShowDialog();
        }

        private void btn_consultar_Click_1(object sender, EventArgs e)
        {
            NE_Articulos art = new NE_Articulos();

            if (txt_codigo.Text == "" && txt_nombre.Text == "")
            {
                CargarGrilla(art.RecuperarTodos());
            }
            if (txt_codigo.Text != "" && txt_nombre.Text != "")
            {
                CargarGrilla(art.Recuperar_Mixto(txt_codigo.Text, txt_nombre.Text));
                return;
            }
            if (txt_codigo.Text != "")
            {
                CargarGrilla(art.Recuperar_x_Codigo(txt_codigo.Text));
            }
            if (txt_nombre.Text != "")
            {
                CargarGrilla(art.Recuperar_x_Nombre(txt_nombre.Text));
            }
        }

        private void grid_articulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_articulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
