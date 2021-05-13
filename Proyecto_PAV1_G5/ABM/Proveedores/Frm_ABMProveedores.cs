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
        public string[] Pp_legajo { get; set; }
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
                grid_proveedores.Rows[i].Cells[4].Value = tabla.Rows[i]["barrio"].ToString();
                grid_proveedores.Rows[i].Cells[5].Value = tabla.Rows[i]["calle"].ToString();
                grid_proveedores.Rows[i].Cells[6].Value = tabla.Rows[i]["nro_calle"].ToString();
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            CargarGrilla(prov.RecuperarTodos());
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
