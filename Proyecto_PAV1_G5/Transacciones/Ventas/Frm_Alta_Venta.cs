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

namespace Proyecto_PAV1_G5.Transacciones.Ventas
{
    public partial class Frm_Alta_Venta : Form
    {
        NE_Ventas venta = new NE_Ventas();
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

        public Frm_Alta_Venta()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Alta_Venta_Load(object sender, EventArgs e)
        {
            grid_articulos.Formatear("Codigo,75; Nombre,200; Precio Mayorista,100; Precio Minorista,100; Cantidad,50");
            grid_equipos.Formatear("Codigo,100; Nombre,200; Precio Mayorista,100; Precio Minorista,100; Cantidad,50");
            grid_equipos_especiales.Formatear("Codigo,100; Cuit del Cliente,125; Precio,125; Nombre,100; Cantidad,50");
            cmb_id_tipo_factura.SelectedIndex = -1;
            cmb_id_forma_pago.CargarCombo(venta.DatosComboFormaDePago());
            cmb_id_tipo_factura.CargarCombo(venta.DatosComboTipoFactura());
            cmb_legajo_vendedor.CargarCombo(venta.DatosComboEmpleado());
            cmb_nombre_articulo.CargarCombo(venta.DatosComboArticulos());
            cmb_equipos.CargarCombo(venta.DatosComboEquipos());
            cmb_equipos_especiales.Enabled = false;
            btn_agregar_equipos_especiales.Enabled = false;
            cmb_cuit_cliente.Enabled = false;
            txt_cantidad_equipos_especiales.ReadOnly = true;
            cmb_equipos.Enabled = false;
            cmb_nombre_articulo.Enabled = false;
            txt_cantidad_articulo.ReadOnly = true;
            txt_cantidad_equipos.ReadOnly = true;
            btn_agregar_articulos.Enabled = false;
            btn_agregar_equipos.Enabled = false;
            txt_fecha.Text = tratamiento.RecuperarFecha();
        }

        private void cmb_id_tipo_factura_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_id_tipo_factura.Text == "A")
            {
                cmb_cuit_cliente.Enabled = true;
                cmb_cuit_cliente.CargarCombo(venta.DatosComboCliente());
                cmb_equipos_especiales.Enabled = false;
                txt_cantidad_equipos_especiales.ReadOnly = true;
                btn_agregar_equipos_especiales.Enabled = false;

                cmb_equipos.Enabled = true;
                cmb_nombre_articulo.Enabled = true;
                txt_cantidad_articulo.ReadOnly = false;
                txt_cantidad_equipos.ReadOnly = false;
                btn_agregar_articulos.Enabled = true;
                btn_agregar_equipos.Enabled = true;
                txt_monto.Text = CalcularPrecioMayorista(grid_equipos, grid_equipos_especiales, grid_articulos);
            }
            if (cmb_id_tipo_factura.Text == "C")
            {
                cmb_cuit_cliente.SelectedIndex = -1;
                cmb_cuit_cliente.Enabled = false;
                btn_agregar_equipos_especiales.Enabled = false;
                cmb_equipos_especiales.Enabled = false;
                txt_cantidad_equipos_especiales.ReadOnly = true;
                cmb_equipos.Enabled = true;
                cmb_nombre_articulo.Enabled = true;
                txt_cantidad_articulo.ReadOnly = false;
                txt_cantidad_equipos.ReadOnly = false;
                btn_agregar_articulos.Enabled = true;
                btn_agregar_equipos.Enabled = true;
                grid_equipos_especiales.Rows.Clear();
                txt_monto.Text = CalcularPrecioMinorista(grid_equipos, grid_articulos);

            }
        }

        private void btn_agregar_articulos_Click(object sender, EventArgs e)
        {
            if (txt_cantidad_articulo.Text == "")
            {
                MessageBox.Show("Falta cargar la cantidad de artículos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_cantidad_articulo.Focus();
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
                                    , txt_cantidad_articulo.Text);

            cmb_nombre_articulo.SelectedIndex = -1;
            txt_descripcion_articulo.Text = "";
            txt_precio_mayorista_articulo.Text = "";
            txt_precio_minorista_articulo.Text = "";
            txt_cantidad_articulo.Text = "";

            if (cmb_id_tipo_factura.Text == "A")
            {
                txt_monto.Text = CalcularPrecioMayorista(grid_equipos, grid_equipos_especiales, grid_articulos);
            }
            else
            {
                txt_monto.Text = CalcularPrecioMinorista(grid_equipos, grid_articulos);
            }
        }

        private void btn_agregar_equipos_especiales_Click(object sender, EventArgs e)
        {
            if (txt_cantidad_equipos_especiales.Text == "")
            {
                MessageBox.Show("Falta cargar la cantidad de equipos especiales", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_cantidad_equipos_especiales.Focus();
                return;
            }

            if (cmb_equipos_especiales.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleccionar el equipo especial", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_equipos_especiales.Focus();
                return;
            }
            grid_equipos_especiales.Rows.Add(
                                    cmb_equipos_especiales.SelectedValue.ToString()
                                    , cmb_cuit_cliente.SelectedValue.ToString()
                                    , txt_precio_mayorista_equipos_especiales.Text
                                    , cmb_equipos_especiales.Text
                                    , txt_cantidad_equipos_especiales.Text);

            cmb_equipos_especiales.SelectedIndex = -1;
            txt_precio_mayorista_equipos_especiales.Text = "";
            txt_cantidad_equipos_especiales.Text = "";

            if (cmb_id_tipo_factura.Text == "A")
            {
                txt_monto.Text = CalcularPrecioMayorista(grid_equipos, grid_equipos_especiales, grid_articulos);
            }
            else
            {
                txt_monto.Text = CalcularPrecioMinorista(grid_equipos, grid_articulos);
            }
        }

        private void btn_agregar_equipos_Click(object sender, EventArgs e)
        {
            if (txt_cantidad_equipos.Text == "")
            {
                MessageBox.Show("Falta cargar la cantidad de equipos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_cantidad_equipos.Focus();
                return;
            }

            if (cmb_equipos.SelectedIndex == -1)
            {
                MessageBox.Show("Falta seleccionar el equipo", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_equipos.Focus();
                return;
            }

            grid_equipos.Rows.Add(
                                    cmb_equipos.SelectedValue.ToString()
                                    , cmb_equipos.Text
                                    , txt_precio_mayorista_equipos.Text
                                    , txt_precio_minorista_equipos.Text
                                    , txt_cantidad_equipos.Text);

            cmb_equipos.SelectedIndex = -1;
            txt_precio_mayorista_equipos.Text = "";
            txt_precio_minorista_equipos.Text = "";
            txt_cantidad_equipos.Text = "";

            if(cmb_id_tipo_factura.Text == "A")
            {
                txt_monto.Text = CalcularPrecioMayorista(grid_equipos, grid_equipos_especiales, grid_articulos);
            }
            else
            {
                txt_monto.Text = CalcularPrecioMinorista(grid_equipos, grid_articulos);
            }
        }

        private string CalcularPrecioMayorista(Grid01 grid_equipos, Grid01 grid_equipos_especiales, Grid01 grid_articulos)
        {
            bool bandera_articulo = false;
            bool bandera_equipo = false;
            bool bandera_equipo_especial = false;
            if (grid_articulos.Rows.Count != 0)
            {
                bandera_articulo = true;
            }
            if (grid_equipos.Rows.Count != 0)
            {
                bandera_equipo = true;
            }
            if (grid_equipos_especiales.Rows.Count != 0)
            {
                bandera_equipo_especial = true;
            }
            int calculo = 0;

            for (int i = 0; i < grid_articulos.Rows.Count; i++)
            {
                if(bandera_articulo)
                {
                    calculo += int.Parse(grid_articulos.Rows[i].Cells[2].Value.ToString()) * int.Parse(grid_articulos.Rows[i].Cells[4].Value.ToString());
                }
            }

            for (int i = 0; i < grid_equipos.Rows.Count; i++)
            {
                if (bandera_equipo)
                {
                    calculo += int.Parse(grid_equipos.Rows[i].Cells[2].Value.ToString()) * int.Parse(grid_equipos.Rows[i].Cells[4].Value.ToString());
                }
            }

            for (int i = 0; i < grid_equipos_especiales.Rows.Count; i++)
            {
                if (bandera_equipo_especial)
                {
                    calculo += int.Parse(grid_equipos_especiales.Rows[i].Cells[2].Value.ToString()) * int.Parse(grid_equipos_especiales.Rows[i].Cells[4].Value.ToString());
                }
            }
            return (int.Parse(calculo.ToString())).ToString();
        }

        private string CalcularPrecioMinorista(Grid01 grid_equipos, Grid01 grid_articulos)
        {
            bool bandera_articulo = false;
            bool bandera_equipo = false;
            if (grid_articulos.Rows.Count != 0)
            {
                bandera_articulo = true;
            }
            if (grid_equipos.Rows.Count != 0)
            {
                bandera_equipo = true;
            }
            int calculo = 0;

            for (int i = 0; i < grid_articulos.Rows.Count; i++)
            {
                if (bandera_articulo)
                {
                    calculo += int.Parse(grid_articulos.Rows[i].Cells[3].Value.ToString()) * int.Parse(grid_articulos.Rows[i].Cells[4].Value.ToString());
                }
            }

            for (int i = 0; i < grid_equipos.Rows.Count; i++)
            {
                if (bandera_equipo)
                {
                    calculo += int.Parse(grid_equipos.Rows[i].Cells[3].Value.ToString()) * int.Parse(grid_equipos.Rows[i].Cells[4].Value.ToString());
                }
            }
            
            return (double.Parse(calculo.ToString())).ToString();
        }

        private void cmb_nombre_articulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tabla = venta.RecuperarArticulo(cmb_nombre_articulo.SelectedValue.ToString());
            txt_descripcion_articulo.Text = tabla.Rows[0][2].ToString();
            txt_precio_minorista_articulo.Text = tabla.Rows[0][7].ToString();
            txt_precio_mayorista_articulo.Text = tabla.Rows[0][6].ToString();
        }

        private void cmb_equipos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tabla = venta.RecuperarEquipo(cmb_equipos.SelectedValue.ToString());
            txt_precio_minorista_equipos.Text = tabla.Rows[0][2].ToString();
            txt_precio_mayorista_equipos.Text = tabla.Rows[0][1].ToString();
        }

        private void cmb_equipos_especiales_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tabla = venta.RecuperarEquipoEspecial(cmb_equipos_especiales.SelectedValue.ToString());
            txt_precio_mayorista_equipos_especiales.Text = tabla.Rows[0][3].ToString();
            txt_descripcion_equipo_especial.Text = tabla.Rows[0][2].ToString();
        }

        private void cmb_cuit_cliente_SelectedValueChanged(object sender, EventArgs e)
        {
            cmb_equipos_especiales.Enabled = true;
            txt_cantidad_equipos_especiales.ReadOnly = false;
            btn_agregar_equipos_especiales.Enabled = true;

        }

        private void cmb_cuit_cliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_equipos_especiales.CargarCombo(venta.DatosComboEquiposEspeciales(cmb_cuit_cliente.SelectedValue.ToString()));
        }

        // BOTON ACEPTAR VENTA
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            venta.Pp_Forma_Pago = cmb_id_forma_pago.SelectedValue.ToString();
            venta.Pp_Id_Tipo_Factura = cmb_id_tipo_factura.SelectedValue.ToString();
            venta.Pp_Nro_Factura = txt_numero_factura.Text;
            venta.Pp_Monto = txt_monto.Text;
            venta.Pp_Fecha_Venta = txt_fecha.Text;
            venta.Pp_Vendedor = cmb_legajo_vendedor.SelectedValue.ToString();


            if (cmb_id_tipo_factura.Text == "A")
            {
                venta.Pp_Cliente = cmb_cuit_cliente.SelectedValue.ToString();
                venta.InsertarVentaMayorista(grid_equipos, grid_equipos_especiales, grid_articulos);
            }

            if (cmb_id_tipo_factura.Text == "C")
            {
                venta.InsertarVentaMinorista(grid_equipos, grid_equipos_especiales, grid_articulos);
            }
            this.Close();
        }

        private void grid_articulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar el articulo seleccionado?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grid_articulos.Rows.Remove(grid_articulos.CurrentRow);
                if(cmb_id_tipo_factura.Text == "A")
                {
                    txt_monto.Text = CalcularPrecioMayorista(grid_equipos, grid_equipos_especiales, grid_articulos);
                }
                else
                {
                    txt_monto.Text = CalcularPrecioMinorista(grid_equipos, grid_articulos);
                }
            }
        }

        private void grid_equipos_especiales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar el equipo especial seleccionado?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grid_equipos_especiales.Rows.Remove(grid_equipos_especiales.CurrentRow);
                if (cmb_id_tipo_factura.Text == "A")
                {
                    txt_monto.Text = CalcularPrecioMayorista(grid_equipos, grid_equipos_especiales, grid_articulos);
                }
                else
                {
                    txt_monto.Text = CalcularPrecioMinorista(grid_equipos, grid_articulos);
                }
            }
        }

        private void grid_equipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar el equipo seleccionado?", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                grid_equipos.Rows.Remove(grid_equipos.CurrentRow);
                if (cmb_id_tipo_factura.Text == "A")
                {
                    txt_monto.Text = CalcularPrecioMayorista(grid_equipos, grid_equipos_especiales, grid_articulos);
                }
                else
                {
                    txt_monto.Text = CalcularPrecioMinorista(grid_equipos, grid_articulos);
                }
            }
        }

        private void cmb_id_tipo_factura_SelectionChangeCommitted(object sender, EventArgs e)
        {
            venta.Pp_Id_Tipo_Factura = cmb_id_tipo_factura.SelectedValue.ToString();
            txt_numero_factura.Text = venta.RecuperarNumeroFactura().ToString();
        }
    }
}
