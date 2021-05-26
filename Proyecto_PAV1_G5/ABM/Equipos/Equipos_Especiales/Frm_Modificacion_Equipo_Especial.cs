using Proyecto_PAV1_G5.BackEnd;
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

namespace Proyecto_PAV1_G5.ABM.Equipos.Equipos_Especiales
{
    public partial class Frm_Modificacion_Equipo_Especial : Form
    {
        public string TipoEquipo { get; set; }
        public string[] Pp_codigo_y_cuit_equipo_especial;
        public string[] Pp_codigo_equipo_simple { get; set; }

        NE_EquiposEspeciales equipoEs = new NE_EquiposEspeciales();
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();


        public Frm_Modificacion_Equipo_Especial()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (TipoEquipo == "simple")
            {
                equipoEs.Precio_Mayorista = txt_Precio_Mayorista.Text;
                equipoEs.Precio_Minorista = txt_Precio_Minorista.Text;
                equipoEs.Nombre_Equipo = txt_Nombre.Text;
                equipoEs.Codigo_Equipo = txt_Codigo_Equipo.Text;
                equipoEs.Modificar_Equipo_Simple(grid_articulos);

            }
            if(TipoEquipo == "especial")
            {
                equipoEs.Precio_Mayorista = txt_Precio_Mayorista.Text;
                equipoEs.Nombre_Equipo = txt_Nombre.Text;
                equipoEs.Codigo_Equipo = txt_Codigo_Equipo.Text;
                equipoEs.Descripcion = txt_Descripcion.Text;
                equipoEs.Cuit_Cliente = cmb_clientes.SelectedValue.ToString();
                equipoEs.Modificar_Equipo_Especial(grid_articulos);
            }
            this.Close();
        }

        private void MostrarDatos(DataTable tabla)
        {
            if (TipoEquipo == "especial")
            {
                txt_Codigo_Equipo.Text = tabla.Rows[0]["codigo_equipo_especial"].ToString();
                cmb_clientes.SelectedValue = tabla.Rows[0]["cuit_cliente"].ToString();
                txt_Descripcion.Text = tabla.Rows[0]["descripcion"].ToString();
                txt_Precio_Mayorista.Text = tabla.Rows[0]["precio"].ToString();
                txt_Nombre.Text = tabla.Rows[0]["nombre_equipo_especial"].ToString();
            }
            if (TipoEquipo == "simple")
            {
                txt_Codigo_Equipo.Text = tabla.Rows[0]["codigo_equipo"].ToString();
                txt_Precio_Mayorista.Text = tabla.Rows[0]["precio_mayorista"].ToString();
                txt_Precio_Minorista.Text = tabla.Rows[0]["precio_minorista"].ToString();
                txt_Nombre.Text = tabla.Rows[0]["nombre_equipo"].ToString();
            }
        }

        private void Frm_Modificacion_Equipo_Especial_Load(object sender, EventArgs e)
        {

            grid_articulos.Formatear("Codigo,75; Nombre,200; Precio Mayorista,100; Precio Minorista,100; Cantidad,50");
            cmb_nombre_articulo.CargarCombo(equipoEs.DatosComboArticulo());
            cmb_clientes.CargarCombo(equipoEs.DatosComboCliente());
            if (TipoEquipo == "simple")
            {
                label_titulo.Text = "Modificación Equipo Simple";
                MostrarDatos(equipoEs.Recuperar_x_Codigo_Array(Pp_codigo_equipo_simple));
                label_cuit.Hide();
                cmb_clientes.Hide();
                label_descripcion.Hide();
                txt_Descripcion.Hide();
                label_precio_minorista.Show();
                txt_Precio_Minorista.Show();

                grid_articulos.Cargar(equipoEs.RecuperarArticulo_X_Equipo(Pp_codigo_equipo_simple[0]));

            }
            if (TipoEquipo == "especial")
            {
                label_titulo.Text = "Modificación Equipo Especial";
                MostrarDatos(equipoEs.Recuperar_x_Codigo_y_Cuit_Array(Pp_codigo_y_cuit_equipo_especial));
                label_cuit.Show();
                cmb_clientes.Show();
                label_descripcion.Show();
                txt_Descripcion.Show();
                label_precio_minorista.Hide();
                txt_Precio_Minorista.Hide();
                grid_articulos.Cargar(equipoEs.RecuperarArticulo_X_Equipo_Especial(Pp_codigo_y_cuit_equipo_especial[0], Pp_codigo_y_cuit_equipo_especial[1]));
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
            return (double.Parse(calculo.ToString()) * 0.9).ToString();
        }

        private void cmb_nombre_articulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tabla = equipoEs.RecuperarArticulo(cmb_nombre_articulo.SelectedValue.ToString());
            txt_descripcion_articulo.Text = tabla.Rows[0][2].ToString();
            txt_precio_minorista_articulo.Text = tabla.Rows[0][7].ToString();
            txt_precio_mayorista_articulo.Text = tabla.Rows[0][6].ToString();
        }

        private void grid_articulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar el articulo seleccionado?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grid_articulos.Rows.Remove(grid_articulos.CurrentRow);
                txt_Precio_Mayorista.Text = CalcularPrecioMayorista(grid_articulos);
                txt_Precio_Minorista.Text = CalcularPrecioMinorista(grid_articulos);
            }
        }
    }
}
