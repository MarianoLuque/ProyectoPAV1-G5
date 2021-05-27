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
        public string Pp_Nro_Factura { get; set; }
        public string Pp_Id_Tipo_Factura { get; set; }
        Acceso_Datos _BD = new Acceso_Datos();
        Acceso_Datos_T _BD_T = new Acceso_Datos_T();
        public Estructura_ComboBox DatosComboCliente()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "cuit_clientes";
            edc.Display = "razon_social";
            edc.Sql = "SELECT * FROM Clientes";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        public Estructura_ComboBox DatosComboTipoFactura()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "id_tipo_factura";
            edc.Display = "nombre_tipo_factura";
            edc.Sql = "SELECT * FROM Tipos_Facturas";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        public Estructura_ComboBox DatosComboEmpleado()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "legajo";
            edc.Display = "vendedor";
            edc.Sql = "SELECT (nombre + ' ' + apellido) as vendedor FROM Empleados";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        public Estructura_ComboBox DatosComboFormaDePago()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "id_forma_pago";
            edc.Display = "nombre_forma_pago";
            edc.Sql = "SELECT * FROM Formas_De_Pago";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        public Estructura_ComboBox DatosComboArticulos()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "codigo_articulo";
            edc.Display = "nombre_articulo";
            edc.Sql = "SELECT * FROM Articulos";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        public Estructura_ComboBox DatosComboEquipos()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "codigo_equipo";
            edc.Display = "nombre_equipo";
            edc.Sql = "SELECT * FROM Equipos";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        public Estructura_ComboBox DatosComboEquiposEspeciales(string cuit)
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "codigo_equipo_especial";
            edc.Display = "nombre_equipo_especial";
            edc.Sql = "SELECT * FROM Equipos_Especiales WHERE cuit_cliente = " + cuit;
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

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

        public int RecuperarNumeroFactura()
        {
            string Sql = "SELECT MAX(nro_factura) FROM Facturas";
            DataTable tabla = _BD.Ejecutar_Select(Sql);
            return (int.Parse(tabla.Rows[0][0].ToString()) + 1);
        }

        public DataTable RecuperarArticulo(string codigo)
        {
            string sql = "SELECT * FROM Articulos WHERE codigo_articulo = " + codigo;
            return (_BD.Ejecutar_Select(sql));
        }

        public DataTable RecuperarEquipo(string codigo)
        {
            string sql = "SELECT * FROM Equipos WHERE codigo_equipo = " + codigo;
            return (_BD.Ejecutar_Select(sql));
        }

        public DataTable RecuperarEquipoEspecial(string codigo, string razon_social)
        {
            string sql = "SELECT * FROM Equipos_Especiales e " +
                         "JOIN Clientes c ON e.cuit_cliente = c.cuit_clientes " +
                         "WHERE e.codigo_equipo_especial = " + codigo + " AND c.razon_social = '" + razon_social + "'";
            return (_BD.Ejecutar_Select(sql));
        }

        public void InsertarVenta(Grid01 grid_equipos, Grid01 grid_equipos_especiales, Grid01 grid_articulos)
        {
            string SqlInsertar = @"INSERT INTO ";

            _BD_T.InicioTransaccion();
            _BD_T.Insertar(SqlInsertar);
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
            string Sql = @"INSERT INTO Detalles_Facturas ";
        }
    }
}
