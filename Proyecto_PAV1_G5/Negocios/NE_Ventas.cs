using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_PAV1_G5.Clases;
using Proyecto_PAV1_G5.BackEnd;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_PAV1_G5.Negocios
{
    class NE_Ventas
    {
        // ZONA DE DECLARACIONES
        public string Pp_Id_Tipo_Factura { get; set; }
        public string Pp_Cliente { get; set; }
        public string Pp_Nro_Factura { get; set; }
        public string Pp_Monto { get; set; }
        public string Pp_Fecha_Venta { get; set; }
        public string Pp_Vendedor { get; set; }
        public string Pp_Forma_Pago { get; set; }

        Acceso_Datos _BD = new Acceso_Datos();
        Acceso_Datos_T _BD_T = new Acceso_Datos_T();

        // ESTRUCTURA COMBO BOX DE CLIENTES
        public Estructura_ComboBox DatosComboCliente()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "cuit_clientes";
            edc.Display = "razon_social";
            edc.Sql = "SELECT * FROM Clientes";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        // ESTRUCTURA COMBO BOX DE TIPO DE FACTURA
        public Estructura_ComboBox DatosComboTipoFactura()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "id_tipo_factura";
            edc.Display = "nombre_tipo_factura";
            edc.Sql = "SELECT * FROM Tipos_Facturas";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        // ESTRUCTURA COMBO BOX DE EMPLEADO
        public Estructura_ComboBox DatosComboEmpleado()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "legajo";
            edc.Display = "vendedor";
            edc.Sql = "SELECT *, (nombre + ' ' + apellido) as vendedor FROM Empleados";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        // ESTRUCTURA DE COMBO BOX FORMA DE PAGO
        public Estructura_ComboBox DatosComboFormaDePago()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "id_forma_pago";
            edc.Display = "nombre_forma_pago";
            edc.Sql = "SELECT * FROM Formas_De_Pago";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        // ESTRUCTURA DE DOMBO BOX ARTICULOS
        public Estructura_ComboBox DatosComboArticulos()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "codigo_articulo";
            edc.Display = "nombre_articulo";
            edc.Sql = "SELECT * FROM Articulos";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        // ESTRUCTURA DE DOMBO BOX EQUIPOS SIMPLES
        public Estructura_ComboBox DatosComboEquipos()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "codigo_equipo";
            edc.Display = "nombre_equipo";
            edc.Sql = "SELECT * FROM Equipos";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        // // ESTRUCTURA DE DOMBO BOX EQUIPOS ESPECIALES
        public Estructura_ComboBox DatosComboEquiposEspeciales(string cuit)
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "codigo_equipo_especial";
            edc.Display = "nombre_equipo_especial";
            edc.Sql = "SELECT * FROM Equipos_Especiales WHERE cuit_cliente = " + cuit;
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }


        // Z O N A      D E      R E C U P E R A C I O N E S
        //Numero Factura; Tipo Factura; Cuit Cliente; Monto Total; Fecha de Venta; Vendedor Asignado; Forma de Pago
        public DataTable RecuperarTodos()
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Solo_Por_Cuit(string cuit)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit;

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Cuit_Y_Tipo_Factura(string cuit, string tipo_Factura)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit
                         + " AND tf.id_tipo_factura = " + tipo_Factura;

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Cuit_Tipo_Factura_Fecha_Desde(string cuit, string tipo_Factura, string fecha)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit
                         + " AND tf.id_tipo_factura = " + tipo_Factura
                         + " AND f.fecha_venta >= Convert (Date, '" + fecha + "', 103)";
            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Cuit_Tipo_Factura_Fecha_Desde_Fecha_Hasta(string cuit, string tipo_Factura, string fecha_desde, string fecha_hasta)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit
                         + " AND tf.id_tipo_factura = " + tipo_Factura
                         + " AND f.fecha_venta >= Convert (Date, '" + fecha_desde + "', 103)"
                         + " AND f.fecha_venta <= Convert (Date, '" + fecha_hasta + "', 103)";
            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Tipo_Factura(string tipo_factura)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE tf.id_tipo_factura = " + tipo_factura;

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Tipo_Factura_Fecha_Desde(string tipo_factura, string fecha_desde)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE tf.id_tipo_factura = " + tipo_factura
                         + " AND f.fecha_venta >= Convert (Date, '" + fecha_desde + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Tipo_Factura_Fecha_Hasta(string tipo_factura, string fecha_hasta)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE tf.id_tipo_factura = " + tipo_factura
                         + " AND f.fecha_venta <= Convert (Date, '" + fecha_hasta + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Tipo_Factura_Fecha_Desde_Fecha_Hasta(string tipo_factura, string fecha_desde, string fecha_hasta)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE tf.id_tipo_factura = " + tipo_factura
                         + " AND f.fecha_venta >= Convert (Date, '" + fecha_desde + "', 103)"
                         + " AND f.fecha_venta <= Convert (Date, '" + fecha_hasta + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Cuit_Fecha_Desde(string cuit, string fecha_desde)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit
                         + " AND f.fecha_venta >= Convert (Date, '" + fecha_desde + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Cuit_Fecha_Hasta(string cuit, string fecha_hasta)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit
                         + " AND f.fecha_venta <= Convert (Date, '" + fecha_hasta + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Fecha_Desde(string fecha_desde)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE f.fecha_venta >= Convert (Date, '" + fecha_desde + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Fecha_Hasta(string fecha_hasta)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE f.fecha_venta <= Convert (Date, '" + fecha_hasta + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Fecha_Desde_Fecha_Hasta(string fecha_desde, string fecha_hasta)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE f.fecha_venta <= Convert (Date, '" + fecha_hasta + "', 103)"
                         + " AND f.fecha_venta >= Convert (Date, '" + fecha_desde + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Cuit_Fecha_Desde_Fecha_Hasta(string cuit, string fecha_desde, string fecha_hasta)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit
                         + " AND f.fecha_venta <= Convert (Date, '" + fecha_hasta + "', 103)"
                         + " AND f.fecha_venta >= Convert (Date, '" + fecha_desde + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Cuit_Tipo_Factura_Fecha_Hasta(string cuit, string tipo_Factura, string fecha)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit
                         + " AND tf.id_tipo_factura = " + tipo_Factura
                         + " AND f.fecha_venta <= Convert (Date, '" + fecha + "', 103)";
            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Detalle_X_Nro_Y_Tipo_Factura(string nro_factura, string tipo_factura)
        {
            string Sql = @"SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, tp.nombre_tipo_producto, df.codigo_articulo, df.codigo_equipo, df.codigo_equipo_especial, df.cantidad, df.precio_unitario, Convert(char(10), f.fecha_venta , 103), (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f" +
                          " JOIN Detalles_Facturas df ON (f.nro_factura = df.nro_factura and f.id_tipo_factura = df.id_tipo_factura)" +
                          " JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago" +
                          " JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura" +
                          " JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                          " LEFT JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes" +
                          " JOIN Tipos_Productos tp ON df.tipo_producto = tp.id_tipo_producto" +
                          " WHERE f.nro_factura = " + nro_factura +
                          " AND f.id_tipo_factura = " + tipo_factura;
            return (_BD.Ejecutar_Select(Sql));
        }

        // RECUPERACION DEL NUMERO DE FACTURA
        public int RecuperarNumeroFactura()
        {
            string Sql = "SELECT MAX(nro_factura) FROM Facturas WHERE id_tipo_factura = " + Pp_Id_Tipo_Factura;
            DataTable tabla = _BD.Ejecutar_Select(Sql);
            if (tabla.Rows[0][0].ToString() == "")
            {
                return 1;
            }
            else
            {
                return (int.Parse(tabla.Rows[0][0].ToString()) + 1);
            }
        }

        //RECUPERACION DEL ORDEN DE DETALLE FACTURA
        public string RecuperarOrdenDetalleFactura(string tipo_producto)
        {
            string Sql = @"SELECT MAX(orden_producto) FROM Detalles_Facturas WHERE id_tipo_factura = " + Pp_Id_Tipo_Factura
                        + " AND nro_factura = " + Pp_Nro_Factura + " AND tipo_producto = " + tipo_producto;
            DataTable tabla = _BD.Ejecutar_Select(Sql);
            if (tabla.Rows[0][0].ToString() == "")
            {
                return "1";
            }
            else
            {
                return ((int.Parse(tabla.Rows[0][0].ToString()) + 1).ToString());
            }
        }

        // RECUPERACION DE ARTICULO
        public DataTable RecuperarArticulo(string codigo)
        {
            string sql = "SELECT * FROM Articulos WHERE codigo_articulo = " + codigo;
            return (_BD.Ejecutar_Select(sql));
        }

        // RECUPERACION DE EQUIPO
        public DataTable RecuperarEquipo(string codigo)
        {
            string sql = "SELECT * FROM Equipos WHERE codigo_equipo = " + codigo;
            return (_BD.Ejecutar_Select(sql));
        }

        // RECUPERACION DE EQUIPOS ESPECIALES
        public DataTable RecuperarEquipoEspecial(string codigo)
        {
            string sql = "SELECT * FROM Equipos_Especiales " +
                         "WHERE codigo_equipo_especial = " + codigo;
            return (_BD.Ejecutar_Select(sql));
        }


        // Z O N A     D E     I N S E R S I O N E S 
        public void InsertarVentaMayorista(Grid01 grid_equipos, Grid01 grid_equipos_especiales, Grid01 grid_articulos)
        {
            string SqlInsertar = @"INSERT INTO Facturas 
                                (nro_factura, id_tipo_factura, cuit_cliente, monto_total, fecha_venta, legajo_vendedor, id_forma_pago) VALUES ( "
                                + Pp_Nro_Factura
                                + ", " + Pp_Id_Tipo_Factura
                                + ", " + Pp_Cliente
                                + ", " + Pp_Monto
                                + ", Convert(Date, '" + Pp_Fecha_Venta + "', 103)"
                                + ", " + Pp_Vendedor
                                + ", " + Pp_Forma_Pago + ")";


            _BD_T.InicioTransaccion();
            ActualizarClasificacionCliente(Pp_Cliente);
            _BD_T.Insertar(SqlInsertar);
            InsertarDetalleFactura(grid_equipos, grid_equipos_especiales, grid_articulos);
            if (_BD_T.FinalTransaccion() == Acceso_Datos_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se registró la venta correctamente");

                ActualizarCantidadStockArt(grid_equipos, grid_equipos_especiales, grid_articulos);
            }
            else
            {
                MessageBox.Show("No se registró la venta por un error");
            }
        }

        public void InsertarVentaMinorista(Grid01 grid_equipos, Grid01 grid_equipos_especiales, Grid01 grid_articulos)
        {
            string SqlInsertar = @"INSERT INTO Facturas 
                                (nro_factura, id_tipo_factura, monto_total, fecha_venta, legajo_vendedor, id_forma_pago) VALUES ( "
                                + Pp_Nro_Factura
                                + ", " + Pp_Id_Tipo_Factura
                                + ", " + Pp_Monto
                                + ", Convert(Date, '" + Pp_Fecha_Venta + "', 103)"
                                + ", " + Pp_Vendedor
                                + ", " + Pp_Forma_Pago + ")";


            _BD_T.InicioTransaccion();
            _BD_T.Insertar(SqlInsertar);
            InsertarDetalleFactura(grid_equipos, grid_equipos_especiales, grid_articulos);
            if (_BD_T.FinalTransaccion() == Acceso_Datos_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se registró la venta correctamente");
                ActualizarCantidadStockArt(grid_equipos, grid_equipos_especiales, grid_articulos);

            }
            else
            {
                MessageBox.Show("No se registró la venta por un error");
            }
        }

        public void InsertarDetalleFactura(Grid01 grid_equipos, Grid01 grid_equipos_especiales, Grid01 grid_articulos)
        {
            string SqlArticulo = @"INSERT INTO Detalles_Facturas (nro_factura, id_tipo_factura, tipo_producto, codigo_articulo, cantidad, precio_unitario, orden_producto) VALUES ("
                        + Pp_Nro_Factura
                        + ", " + Pp_Id_Tipo_Factura
                        + ", 1";

            string SqlEquipo = @"INSERT INTO Detalles_Facturas (nro_factura, id_tipo_factura, tipo_producto, codigo_equipo, cantidad, precio_unitario, orden_producto) VALUES ("
                        + Pp_Nro_Factura
                        + ", " + Pp_Id_Tipo_Factura
                        + ", 2";

            string SqlEquipoEspecial = @"INSERT INTO Detalles_Facturas (nro_factura, id_tipo_factura, tipo_producto, codigo_equipo_especial, cantidad, precio_unitario, orden_producto) VALUES ("
                        + Pp_Nro_Factura
                        + ", " + Pp_Id_Tipo_Factura
                        + ", 3";

            for (int i = 0; i < grid_articulos.Rows.Count; i++)
            {
                string miniSql = "";

                if (Pp_Id_Tipo_Factura == "1")
                {
                    miniSql = ", " + grid_articulos.Rows[i].Cells[0].Value.ToString()
                                   + ", " + grid_articulos.Rows[i].Cells[4].Value.ToString()
                                   + ", " + grid_articulos.Rows[i].Cells[2].Value.ToString();
                }

                if (Pp_Id_Tipo_Factura == "2")
                {
                    miniSql = ", " + grid_articulos.Rows[i].Cells[0].Value.ToString()
                                   + ", " + grid_articulos.Rows[i].Cells[4].Value.ToString()
                                   + ", " + grid_articulos.Rows[i].Cells[3].Value.ToString();
                }

                string orden = (i + 1).ToString();

                _BD_T.Insertar(SqlArticulo + miniSql + ", " + orden + ")");
            }

            for (int i = 0; i < grid_equipos.Rows.Count; i++)
            {
                string miniSql = "";

                if (Pp_Id_Tipo_Factura == "1")
                {
                    miniSql = ", " + grid_equipos.Rows[i].Cells[0].Value.ToString()
                                   + ", " + grid_equipos.Rows[i].Cells[4].Value.ToString()
                                   + ", " + grid_equipos.Rows[i].Cells[2].Value.ToString();
                }

                if (Pp_Id_Tipo_Factura == "2")
                {
                    miniSql = ", " + grid_equipos.Rows[i].Cells[0].Value.ToString()
                                   + ", " + grid_equipos.Rows[i].Cells[4].Value.ToString()
                                   + ", " + grid_equipos.Rows[i].Cells[3].Value.ToString();
                }

                string orden = (i + 1).ToString();

                _BD_T.Insertar(SqlEquipo + miniSql + ", " + orden + ")");
            }

            for (int i = 0; i < grid_equipos_especiales.Rows.Count; i++)
            {
                string miniSql = "";

                if (Pp_Id_Tipo_Factura == "1")
                {
                    miniSql = ", " + grid_equipos_especiales.Rows[i].Cells[0].Value.ToString()
                                   + ", " + grid_equipos_especiales.Rows[i].Cells[4].Value.ToString()
                                   + ", " + grid_equipos_especiales.Rows[i].Cells[2].Value.ToString();
                }

                if (Pp_Id_Tipo_Factura == "2")
                {
                    miniSql = ", " + grid_equipos_especiales.Rows[i].Cells[0].Value.ToString()
                                   + ", " + grid_equipos_especiales.Rows[i].Cells[4].Value.ToString()
                                   + ", " + grid_equipos_especiales.Rows[i].Cells[3].Value.ToString();
                }

                string orden = (i + 1).ToString();

                _BD_T.Insertar(SqlEquipoEspecial + miniSql + ", " + orden + ")");
            }

        }
        //METODOS AUXILIARES
        public void ActualizarCantidadStockArt(Grid01 grid_equipos, Grid01 grid_equipos_especiales, Grid01 grid_articulos)
        {
            string sql = "";
            for (int i = 0; i < grid_articulos.Rows.Count; i++)
            {
                sql = "UPDATE Articulos SET cantidad_stock -= " + grid_articulos.Rows[i].Cells[4].Value.ToString() + " WHERE codigo_articulo = " + grid_articulos.Rows[i].Cells[0].Value.ToString();
                _BD.Modificar(sql);
            }

            for (int i = 0; i < grid_equipos.Rows.Count; i++)
            {
                DataTable tabla = ActualizarCantidadStockEquipo(grid_equipos.Rows[i].Cells[0].Value.ToString());
                for (int j = 0; j < tabla.Rows.Count; j++)
                {
                    sql = "UPDATE Articulos SET cantidad_stock -= " + (int.Parse(grid_equipos.Rows[i].Cells[4].Value.ToString()) * int.Parse(tabla.Rows[j][2].ToString())).ToString() + " WHERE codigo_articulo = " + tabla.Rows[j][0].ToString();
                    _BD.Modificar(sql);
                }
            }

            for (int i = 0; i < grid_equipos_especiales.Rows.Count; i++)
            {
                DataTable tabla = ActualizarCantidadStockEquipoEspecial(grid_equipos_especiales.Rows[i].Cells[0].Value.ToString());
                for (int j = 0; j < tabla.Rows.Count; j++)
                {
                    sql = "UPDATE Articulos SET cantidad_stock -= " + (int.Parse(grid_equipos_especiales.Rows[i].Cells[4].Value.ToString()) * int.Parse(tabla.Rows[j][3].ToString())).ToString() + " WHERE codigo_articulo = " + tabla.Rows[j][0].ToString();
                    _BD.Modificar(sql);
                }
            }

        }

        public DataTable ActualizarCantidadStockEquipo(string codigo_equipo)
        {
            string minisql = "SELECT* FROM Articulos_X_Equipo WHERE codigo_equipo = " + codigo_equipo;
            return _BD.Ejecutar_Select(minisql);
        }

        public DataTable ActualizarCantidadStockEquipoEspecial(string codigo_equipo_especial)
        {
            string minisql = "SELECT* FROM Articulos_X_Equipo_Especial WHERE codigo_equipo_especial = " + codigo_equipo_especial;
            return _BD.Ejecutar_Select(minisql);
        }

        public void ActualizarClasificacionCliente(string cuit_cliente, string id_clasificacion)
        {
            string sql = "UPDATE Clientes SET id_clasificacion = " + id_clasificacion + "WHERE cuit_clientes = " + cuit_cliente;
            _BD_T.Modificar(sql);
        }

        //esta devuelve la fecha de la ultima compra hecha hace 2 años, o NULL si no se hicieron compras
        public DataTable FechaUltimaCompra (string cuit_cliente)
        {
            string sql = "SELECT MAX(fecha_venta) FROM Facturas f WHERE cuit_cliente = " + cuit_cliente + " AND YEAR(fecha_venta) >= (YEAR(GETDATE()) - 2)";
            return _BD_T.EjecutarSelect(sql);
        }

        public int CantidadComprasHistoricas(string cuit_cliente)
        {
            string sql = "SELECT cantidad_compras_historicas FROM Clientes WHERE cuit_clientes = " + cuit_cliente;
            return int.Parse((_BD_T.EjecutarSelect(sql)).Rows[0][0].ToString());
        }

        public int IdClasificacion(string cuit_cliente)
        {
            string sql = "SELECT id_clasificacion FROM Clientes WHERE cuit_clientes = " + cuit_cliente;
            return int.Parse((_BD_T.EjecutarSelect(sql)).Rows[0][0].ToString());
        }

        public int DescuentoClasificacion(int cuit_cliente)
        {
            string sqlCliente = "SELECT id_clasificacion FROM Clientes WHERE cuit_clientes = " + cuit_cliente;
            DataTable tabla = _BD_T.EjecutarSelect(sqlCliente);
            string id_clasificacion = tabla.Rows[0][0].ToString();
            string sql = "SELECT descuento FROM Clasificacion_Clientes WHERE id_clasificacion = " + id_clasificacion;
            return int.Parse((_BD_T.EjecutarSelect(sql)).Rows[0][0].ToString());
        }
        public int AntiguedadCliente(string cuit_cliente)
        {
            string sql = "SELECT (YEAR(GETDATE()) - YEAR(fecha_primera_compra)) FROM clientes WHERE cuit_clientes = " + cuit_cliente;
            return int.Parse((_BD_T.EjecutarSelect(sql)).Rows[0][0].ToString());
        }

        public DataTable Clasificaciones_Clientes(int id_clasificacion)
        {
            string sql = "SELECT * FROM Clasificacion_Clientes WHERE id_clasificacion = " + id_clasificacion.ToString();
            return (_BD_T.EjecutarSelect(sql));
        }

        public void ActualizarClasificacion(int clasificacion, string cuit_cliente)
        {
            string sql = "UPDATE Clientes SET id_clasificacion = " + clasificacion.ToString() + " WHERE cuit_clientes = " + cuit_cliente;
            _BD_T.Modificar(sql);
        }

        public void ActualizarClasificacionCliente(string cuit_cliente)
        {
            DataTable tablaFecha = FechaUltimaCompra(cuit_cliente);
            int cantComprasHistoricas = CantidadComprasHistoricas(cuit_cliente);
            int id_clasificacion = IdClasificacion(cuit_cliente);
            int antiguedad = AntiguedadCliente(cuit_cliente);
            //DataTable tablaClasificaciones = Clasificaciones_Clientes(id_clasificacion);
            DataTable tablaClasificacionesMasUno = Clasificaciones_Clientes(id_clasificacion + 1);
            //[0] = "id"
            //[1] = "años_antiguedad"
            //[2] = "cantidad_compras"
            //[3] = "descuento"
            if (tablaFecha.Rows[0][0].ToString() == "")
            {
                string sqlBorrarClasificacion = "UPDATE Clientes SET id_clasificacion = 1, fecha_primera_compra = convert(date, GETDATE(), 103), cantidad_compras_historicas = 0 WHERE cuit_clientes = " + cuit_cliente;
                _BD_T.Modificar(sqlBorrarClasificacion);
            }

            bool banderaCantidadCompras = false;
            bool banderaAntiguedad = false;

            if (cantComprasHistoricas >= int.Parse(tablaClasificacionesMasUno.Rows[0][2].ToString()))
            {
                banderaCantidadCompras = true;
            }
            if (antiguedad >= int.Parse(tablaClasificacionesMasUno.Rows[0][1].ToString()))
            {
                banderaAntiguedad = true;
            }
            if (banderaCantidadCompras && banderaAntiguedad)
            {
                ActualizarClasificacion(id_clasificacion + 1, Pp_Cliente);
            }
        }
    }
}
