using Proyecto_PAV1_G5.Clases;
using Proyecto_PAV1_G5.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAV1_G5.BackEnd;

namespace Proyecto_PAV1_G5.ABM.Equipos.Equipos_Especiales
{
    public partial class Frm_Alta_Equipo_Especial : Form
    {
        public string TipoEquipo { get; set; }
        NE_Equipos_Simples equipoSi = new NE_Equipos_Simples();
        NE_EquiposEspeciales equipoEs = new NE_EquiposEspeciales();
        

        public Frm_Alta_Equipo_Especial()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            equipoEs.Precio_Mayorista = txt_Precio_Mayorista.Text;
            equipoEs.Precio_Minorista = txt_Precio_Minorista.Text;
            equipoEs.Nombre_Equipo = txt_Nombre_Equipo_Especial.Text;

            if (TipoEquipo == "especial")
            {
                equipoEs.Cuit_Cliente = cmb_clientes.SelectedValue.ToString();
                equipoEs.Descripcion = txt_Descripcion_Equipo_Especial.Text;
                equipoEs.Codigo_Equipo = txt_Codigo_Equipo_Especial.Text;
                equipoEs.InsertarEquipoEspecial(grid_articulos);
                
            }
            if(TipoEquipo == "simple")
            {
                equipoEs.InsertarEquipoSimple(grid_articulos);
            }
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Alta_Equipo_Especial_Load(object sender, EventArgs e)
        {
            grid_articulos.Formatear("Codigo,75; Nombre,200; Precio Mayorista,100; Precio Minorista,100; Cantidad,50");
            cmb_nombre_articulo.CargarCombo(equipoEs.DatosComboArticulo());
            cmb_clientes.CargarCombo(equipoEs.DatosComboCliente());
            if(TipoEquipo == "simple")
            {
                label_titulo.Text = "Alta Equipo Simple";
                label_precio_minorista.Show();
                txt_Precio_Minorista.Show();
                label_descripcion.Hide();
                label_razon_social.Hide();
                cmb_clientes.Hide();
                txt_Descripcion_Equipo_Especial.Hide();
                txt_Codigo_Equipo_Especial.Hide();
                label_codigo.Hide();
                
            }
            if (TipoEquipo == "especial")
            {
                label_titulo.Text = "Alta Equipo Especial";
                label_precio_minorista.Hide();
                txt_Precio_Minorista.Hide();
                label_descripcion.Show();
                label_razon_social.Show();
                cmb_clientes.Show();
                txt_Descripcion_Equipo_Especial.Show();
                txt_Codigo_Equipo_Especial.Show();
                label_codigo.Show();
                
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_cantidad.Text == "")
            {
                MessageBox.Show("Falta cargar la cantidad de artículos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_cantidad.Focus();
                return;
            }

            if (cmb_nombre_articulo.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleccionar el artículo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_nombre_articulo.Focus();
                return;
            }
            
            grid_articulos.Rows.Add(
                                    cmb_nombre_articulo.SelectedValue.ToString()
                                    , cmb_nombre_articulo.Text
                                    , txt_precio_mayorista_articulo.Text
                                    , txt_precio_minorista_articulo.Text
                                    , txt_cantidad.Text);

            cmb_nombre_articulo.SelectedIndex = -1;
            txt_descripcion_articulo.Text = "";
            txt_precio_mayorista_articulo.Text = "";
            txt_precio_minorista_articulo.Text = "";
            txt_cantidad.Text = "";


            txt_Precio_Mayorista.Text = CalcularPrecioMayorista(grid_articulos);
            txt_Precio_Minorista.Text = CalcularPrecioMinorista(grid_articulos);
        }

        private void cmb_nombre_articulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tabla = equipoEs.RecuperarArticulo(cmb_nombre_articulo.SelectedValue.ToString());
            txt_descripcion_articulo.Text = tabla.Rows[0][2].ToString();
            txt_precio_minorista_articulo.Text = tabla.Rows[0][7].ToString();
            txt_precio_mayorista_articulo.Text = tabla.Rows[0][6].ToString();
        }

        private string CalcularPrecioMayorista(Grid01 grid_articulos)
        {
            int calculo = 0;
            for (int i = 0; i < grid_articulos.Rows.Count; i++)
            {
                calculo += int.Parse(grid_articulos.Rows[i].Cells[2].Value.ToString()) * int.Parse(grid_articulos.Rows[i].Cells[4].Value.ToString());
            }
            return (double.Parse(calculo.ToString()) * 0.9).ToString();
        }

        private string CalcularPrecioMinorista(Grid01 grid_articulos)
        {
            int calculo = 0;
            for (int i = 0; i < grid_articulos.Rows.Count; i++)
            {
                calculo += int.Parse(grid_articulos.Rows[i].Cells[3].Value.ToString()) * int.Parse(grid_articulos.Rows[i].Cells[4].Value.ToString());
            }
            return (double.Parse(calculo.ToString()) * 0.9 ).ToString();
        }

        private void grid_articulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar el articulo seleccionado?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (TipoEquipo == "especial")
                {
                    txt_precio_mayorista_articulo.Text = CalcularPrecioMayorista(grid_articulos);
                }
                if (TipoEquipo == "simple")
                {
                    txt_Precio_Mayorista.Text = CalcularPrecioMayorista(grid_articulos);
                    txt_Precio_Minorista.Text = CalcularPrecioMinorista(grid_articulos);
                }
                grid_articulos.Rows.Remove(grid_articulos.CurrentRow);
            }
        }
    }
}
