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

namespace Proyecto_PAV1_G5.ABM.Rubros
{
    public partial class Frm_ABMRubros : Form
    {
        public string[] Pp_id_rubro { get; set; }
        public Frm_ABMRubros()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Frm_AltaRubro alta = new Frm_AltaRubro();
            alta.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Frm_ModificacionRubro modif = new Frm_ModificacionRubro();
            Pp_id_rubro[0] = grid_rubros.CurrentRow.Cells["id_rubro"].Value.ToString();
            modif.Pp_id_rubro = Pp_id_rubro;
            modif.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_BajaRubro baja = new Frm_BajaRubro();
            Pp_id_rubro[0] = grid_rubros.CurrentRow.Cells["id_rubro"].Value.ToString();
            baja.Pp_id_rubro = Pp_id_rubro;
            baja.ShowDialog();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            NE_Rubros rubro = new NE_Rubros();
            if (txt_nombre_rubro.Text == "")
            {
                CargarGrilla(rubro.RecuperarTodos());
            }
            else
            {
                CargarGrilla(rubro.Recuperar_x_Nombre(txt_nombre_rubro.Text));
            }
        }

        private void CargarGrilla(DataTable tabla)
        {
            //Voy a recorrer la tabla con su contenido para cargar la grilla
            grid_rubros.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_rubros.Rows.Add();
                grid_rubros.Rows[i].Cells[0].Value = tabla.Rows[i]["id_rubro"].ToString();
                grid_rubros.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre_rubro"].ToString();
                grid_rubros.Rows[i].Cells[2].Value = tabla.Rows[i]["descripcion"].ToString();
            }

        }

        private void grid_rubros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] Pp_id_rubro = new string[1];
            Pp_id_rubro[0] = grid_rubros.CurrentRow.Cells["id_rubro"].Value.ToString();
        }
    }
}
