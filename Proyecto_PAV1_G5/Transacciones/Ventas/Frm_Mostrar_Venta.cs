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
using Proyecto_PAV1_G5.Clases;

namespace Proyecto_PAV1_G5.Transacciones.Ventas
{
    public partial class Frm_Mostrar_Venta : Form
    {
        NE_Ventas venta = new NE_Ventas();
        public string Pp_Nro_Factura { get; set; }
        public string Pp_Tipo_Factura { get; set; }
        public Frm_Mostrar_Venta()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Mostrar_Venta_Load(object sender, EventArgs e)
        {
            grid_articulos.Formatear("Codigo,75; Nombre,200; Descripcion,300; Precio,200; Cantidad,50");
            grid_equipos.Formatear("Codigo,75; Nombre,200; Precio,200; Cantidad,125");
            grid_equipos_especiales.Formatear("Codigo,75; Nombre,200; Cliente,150; Descripcion,300; Precio,125; Cantidad,50");
            LlenarDatos();
        }
        //f.nro_factura [0]
        //tf.nombre_tipo_factura [1]
        //c.razon_social [2]
        //f.monto_total [3]
        //tp.nombre_tipo_producto [4]
        //df.codigo_articulo [5]
        //df.codigo_equipo [6]
        //df.codigo_equipo_especial [7]
        //df.cantidad [8] 
        //df.precio_unitario [9]
        //f.fecha_venta [10]
        //(e.nombre + e.apellido) as Vendedor_Asignado [11]
        //fp.nombre_forma_pago [12]
        private void LlenarDatos()
        {
            DataTable tabla = venta.Recuperar_Detalle_X_Nro_Y_Tipo_Factura(Pp_Nro_Factura, Pp_Tipo_Factura);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i][4].ToString() == "Articulo")
                {
                    DataTable tablaArticulo = venta.RecuperarArticulo(tabla.Rows[i][5].ToString());
                    grid_articulos.Rows.Add(
                                            tabla.Rows[i][5].ToString(),
                                            tablaArticulo.Rows[0][1].ToString(),
                                            tablaArticulo.Rows[0][2].ToString(),
                                            tabla.Rows[i][9].ToString(),
                                            tabla.Rows[i][8].ToString()
                                            );
                }

                if (tabla.Rows[i][4].ToString() == "Equipo")
                {
                    DataTable tablaEquipo = venta.RecuperarEquipo(tabla.Rows[i][6].ToString());
                    grid_equipos.Rows.Add(
                                            tabla.Rows[i][6].ToString(),
                                            tablaEquipo.Rows[0][3].ToString(),
                                            tabla.Rows[i][9].ToString(),
                                            tabla.Rows[i][8].ToString()
                                          );
                }

                if(tabla.Rows[i][4].ToString() == "Equipo Especial")
                {
                    DataTable tablaEquipoEspecial = venta.RecuperarEquipoEspecial(tabla.Rows[i][7].ToString());
                    grid_equipos_especiales.Rows.Add(
                                           tabla.Rows[i][7].ToString(),
                                           tablaEquipoEspecial.Rows[0][4].ToString(),
                                           tabla.Rows[i][2].ToString(),
                                           tablaEquipoEspecial.Rows[0][2].ToString(),
                                           tabla.Rows[i][9].ToString(),
                                           tabla.Rows[i][8].ToString()
                                         );
                }
            }

            txt_numero_factura.Text = Pp_Nro_Factura;
            if (Pp_Tipo_Factura == "1")
            {
                txt_id_tipo_factura.Text = "A";
                txt_cuit_cliente.Text = tabla.Rows[0][2].ToString();
            }
            if (Pp_Tipo_Factura == "2")
            {
                txt_id_tipo_factura.Text = "C";
            }
            txt_monto.Text = tabla.Rows[0][3].ToString();
            txt_legajo_vendedor.Text = tabla.Rows[0][11].ToString();
            txt_fecha.Text = tabla.Rows[0][10].ToString();
            txt_id_forma_pago.Text = tabla.Rows[0][12].ToString();

        }
    }
}


