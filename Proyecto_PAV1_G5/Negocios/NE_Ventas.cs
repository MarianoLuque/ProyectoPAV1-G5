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
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Solo_Por_Cuit(string cuit)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit;

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Cuit_Y_Tipo_Factura(string cuit, string tipo_Factura)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit
                         + " AND tf.id_tipo_factura = " + tipo_Factura;

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Cuit_Tipo_Factura_Fecha_Desde(string cuit, string tipo_Factura, string fecha)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit
                         + " AND tf.id_tipo_factura = " + tipo_Factura
                         + " AND f.fecha_venta >= Convert (Date, '" + fecha + "', 103)"; 
            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Cuit_Tipo_Factura_Fecha_Desde_Fecha_Hasta(string cuit, string tipo_Factura, string fecha_desde, string fecha_hasta)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit
                         + " AND tf.id_tipo_factura = " + tipo_Factura
                         + " AND f.fecha_venta >= Convert (Date, '" + fecha_desde + "', 103)"
                         + " AND f.fecha_venta <= Convert (Date, '" + fecha_hasta + "', 103)";
            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Tipo_Factura(string tipo_factura)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE tf.id_tipo_factura = " + tipo_factura;
                         
            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Tipo_Factura_Fecha_Desde(string tipo_factura, string fecha_desde)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE tf.id_tipo_factura = " + tipo_factura
                         + " AND f.fecha_venta >= Convert (Date, '" + fecha_desde + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Tipo_Factura_Fecha_Hasta(string tipo_factura, string fecha_hasta)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE tf.id_tipo_factura = " + tipo_factura
                         + " AND f.fecha_venta <= Convert (Date, '" + fecha_hasta + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Tipo_Factura_Fecha_Desde_Fecha_Hasta(string tipo_factura, string fecha_desde, string fecha_hasta)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE tf.id_tipo_factura = " + tipo_factura
                         + " AND f.fecha_venta >= Convert (Date, '" + fecha_desde + "', 103)"
                         + " AND f.fecha_venta <= Convert (Date, '" + fecha_hasta + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Cuit_Fecha_Desde(string cuit, string fecha_desde)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit
                         + " AND f.fecha_venta >= Convert (Date, '" + fecha_desde + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Cuit_Fecha_Hasta(string cuit, string fecha_hasta)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit
                         + " AND f.fecha_venta <= Convert (Date, '" + fecha_hasta + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Fecha_Desde(string fecha_desde)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE f.fecha_venta >= Convert (Date, '" + fecha_desde + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Fecha_Hasta(string fecha_hasta)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE f.fecha_venta <= Convert (Date, '" + fecha_hasta + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Fecha_Desde_Fecha_Hasta(string fecha_desde, string fecha_hasta)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE f.fecha_venta <= Convert (Date, '" + fecha_hasta + "', 103)"
                         + " AND f.fecha_venta >= Convert (Date, '" + fecha_desde + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Cuit_Fecha_Desde_Fecha_Hasta(string cuit, string fecha_desde, string fecha_hasta)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit
                         + " AND f.fecha_venta <= Convert (Date, '" + fecha_hasta + "', 103)"
                         + " AND f.fecha_venta >= Convert (Date, '" + fecha_desde + "', 103)";

            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_Por_Cuit_Tipo_Factura_Fecha_Hasta(string cuit, string tipo_Factura, string fecha)
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, c.razon_social, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago " +
                         "JOIN Clientes c ON f.cuit_cliente = c.cuit_clientes"
                         + " WHERE c.cuit_clientes = " + cuit
                         + " AND tf.id_tipo_factura = " + tipo_Factura
                         + " AND f.fecha_venta <= Convert (Date, '" + fecha + "', 103)";
            return (_BD.Ejecutar_Select(Sql));
        }

        // RECUPERACION DEL NUMERO DE FACTURA
        public int RecuperarNumeroFactura()
        {
            string Sql = "SELECT MAX(nro_factura) FROM Facturas WHERE id_tipo_factura = " + Pp_Id_Tipo_Factura;
            DataTable tabla = _BD.Ejecutar_Select(Sql);
            if (tabla.Rows.Count == 0)
            {
                return 1;
            }
            else
            {
                return (int.Parse(tabla.Rows[0][0].ToString()) + 1);
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
        public DataTable RecuperarEquipoEspecial(string codigo, string razon_social)
        {
            string sql = "SELECT * FROM Equipos_Especiales e " +
                         "JOIN Clientes c ON e.cuit_cliente = c.cuit_clientes " +
                         "WHERE e.codigo_equipo_especial = " + codigo + " AND c.razon_social = '" + razon_social + "'";
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
            _BD_T.Insertar(SqlInsertar);
            InsertarDetalleFactura(grid_equipos, grid_equipos_especiales, grid_articulos);
            if (_BD_T.FinalTransaccion() == Acceso_Datos_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se grabó correctamente todo");
            }
            else
            {
                MessageBox.Show("No se grabó nada por un error");
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
            //InsertarDetalleFactura(grid_equipos, grid_equipos_especiales, grid_articulos);
            if (_BD_T.FinalTransaccion() == Acceso_Datos_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se grabó correctamente todo");
            }
            else
            {
                MessageBox.Show("No se grabó nada por un error");
            }
        }

        public void InsertarDetalleFactura (Grid01 grid_equipos, Grid01 grid_equipos_especiales, Grid01 grid_articulos)
        {
            string Sql = @"INSERT INTO Detalles_Facturas (nro_factura, id_tipo_factura, codigo_articulo, cantidad, precio_unitario) VALUES ("
                        + Pp_Nro_Factura 
                        + ", " + Pp_Id_Tipo_Factura;

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
                                   +", " + grid_articulos.Rows[i].Cells[3].Value.ToString();
                }

                _BD_T.Insertar(Sql + miniSql + ")");
            }

        }


    }
}
