using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_PAV1_G5.BackEnd;
using Proyecto_PAV1_G5.Clases;
using System.Windows.Forms;

namespace Proyecto_PAV1_G5.Negocios
{
    class NE_Articulos
    {
        Acceso_Datos _BD = new Acceso_Datos();
        Acceso_Datos_T _BD_T = new Acceso_Datos_T();
        public Estructura_ComboBox DatosComboPais()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "id_pais";
            edc.Display = "nombre_pais";
            edc.Sql = "SELECT * FROM Paises";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        public Estructura_ComboBox DatosComboProveedor()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "cuit_proveedor";
            edc.Display = "razon_social";
            edc.Sql = "SELECT * FROM Proveedores";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        public Estructura_ComboBox DatosComboRubro(string cuit_proveedor)
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "r.id_rubro";
            edc.Display = "nombre_rubro";
            edc.Sql = "SELECT * FROM Rubros_X_Proveedor rp JOIN Rubros r ON rp.id_rubro = r.id_rubro WHERE rp.cuit_proveedor = " + cuit_proveedor;
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        public string RecuperarRubroArticulo(string codigo_articulo)
        {
            string sql = "SELECT id_rubro FROM Articulos WHERE codigo_articulo = " + codigo_articulo;
            return (_BD_T.EjecutarSelect(sql).Rows[0][0].ToString());
        }

        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

        public void Insertar(Control.ControlCollection controles)
        {
            _BD.Insertar(tratamiento.ConstructorInsertar("Articulos", controles));
        }

        public void Modificar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Modificar(tratamiento.ConstructorModificar_Sin_PK("Articulos", ValorPk, controles));
        }

        public void Eliminar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Borrar(tratamiento.ConstructorEliminar("Articulos", ValorPk, controles));
        }

        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT a.*, p.razon_social, r.nombre_rubro"
                        + " FROM Articulos a "
                        + " join Proveedores p on p.cuit_proveedor = a.cuit_proveedor"
                        + " JOIN Rubros r on a.id_rubro = r.id_rubro";
            return _BD.Ejecutar_Select(sql);
        }
        public DataTable Recuperar_x_Codigo(string patron)
        {
            string sql = @"SELECT a.*, p.razon_social, r.nombre_rubro"
                        + " FROM Articulos a "
                        + " join Proveedores p on p.cuit_proveedor = a.cuit_proveedor"
                        + " JOIN Rubros r on a.id_rubro = r.id_rubro"
                        + " WHERE a.codigo_articulo like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Nombre(string patron)
        {
            string sql = @"SELECT a.*, p.razon_social, r.nombre_rubro"
                        + " FROM Articulos a "
                        + " join Proveedores p on p.cuit_proveedor = a.cuit_proveedor"
                        + " JOIN Rubros r on a.id_rubro = r.id_rubro"
                        + " WHERE a.nombre_articulo like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_Mixto(string patron_codigo, string patron_nombre)
        {
            string sql = @"SELECT a.*, p.razon_social, r.nombre_rubro"
                        + " FROM Articulos a "
                        + " join Proveedores p on p.cuit_proveedor = a.cuit_proveedor"
                        + " JOIN Rubros r on a.id_rubro = r.id_rubro"
                        + " WHERE a.codigo_articulo like '%" + patron_codigo.Trim() + "%' AND"
                        + " a.nombre_articulo like '%" + patron_nombre.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable RecuperarCodigo(string[] codigo)
        {

            string sql = @"SELECT a.*, p.razon_social, r.nombre_rubro FROM Articulos a " +
                         "JOIN Proveedores p on a.cuit_proveedor = p.cuit_proveedor " +
                         "JOIN Rubros r on a.id_rubro = r.id_rubro " +
                         "WHERE a.codigo_articulo = " + codigo[0];
            return _BD.Ejecutar_Select(sql);
        }

        public void InsertarArticulo(string nombre, string descripcion, string cantidad_stock, string costo_mayorista, string costo_minorista, string id_pais, string cuit_proveedor, string id_rubro, string tiempo_envio, string plazo_pago)
        {
            string sql = @"INSERT INTO Articulos (nombre_articulo, descripcion, cuit_proveedor, tiempo_envio, plazo_pago, costo_mayorista, costo_minorista, id_pais, cantidad_stock, id_rubro) "
                        + " VALUES ('" + nombre + "', '" + descripcion + "', " + cuit_proveedor + ", " + tiempo_envio + ", " + plazo_pago + ", " + costo_mayorista + ", " + costo_minorista + ", " + id_pais + ", " + cantidad_stock + ", " + id_rubro + ")";
            _BD_T.InicioTransaccion();
            _BD_T.Insertar(sql);
            if (_BD_T.FinalTransaccion() == Acceso_Datos_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se agregó el artículo correctamente");
            }
            else
            {
                MessageBox.Show("No se agregó el artículo por un error");
            }
        }

        //public void InsertarRubros_X_Articulo(string id_rubro)
        //{
        //    string sqlCodigo = "SELECT MAX(codigo_articulo) FROM Articulos";
        //    string sql = "INSERT INTO Rubros_X_Articulo (id_rubro, codigo_articulo) VALUES (" + id_rubro + ",";

        //    DataTable tabla = _BD_T.EjecutarSelect(sqlCodigo);
        //    sql += tabla.Rows[0][0].ToString() + ")";
        //    _BD_T.Insertar(sql);
        //}

        public void EliminarArticulo (string codigo_articulo)
        {
            string sqlArticulo = "DELETE FROM Articulos WHERE codigo_articulo = " + codigo_articulo;

            _BD_T.InicioTransaccion();
            _BD_T.Borrar(sqlArticulo);
            if (_BD_T.FinalTransaccion() == Acceso_Datos_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se eliminó el artículo correctamente");
            }
            else
            {
                MessageBox.Show("No se eliminó el artículo por un error");
            }
        }

        //ZONA DE REPORTE

        public DataTable RecuperarArticulosSinStock()
        {
            string sql = @"SELECT a.*
                          FROM Articulos a";
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarArticulosConStock(string cantDesde, string cantHasta)
        {
            string sql = @"SELECT a.*
                          FROM Articulos a
                          WHERE cantidad_stock BETWEEN " + cantDesde + " AND " + cantHasta;
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarArticulosConStockDesde(string cantDesde)
        {
            string sql = @"SELECT a.*
                          FROM Articulos a
                          WHERE cantidad_stock >= " + cantDesde;
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarArticulosConStockHasta(string cantHasta)
        {
            string sql = @"SELECT a.*
                          FROM Articulos a
                          WHERE cantidad_stock <= " + cantHasta;
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarArticulosPorProveedor(string cuit_proveedor)
        {
            string sql = @"SELECT a.*
                          FROM Articulos a
                          WHERE cuit_proveedor = " + cuit_proveedor;
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarArticulosPorProveedoryStock(string cuit_proveedor, string cantDesde, string cantHasta)
        {
            string sql = @"SELECT a.*
                          FROM Articulos a
                          WHERE cuit_proveedor = " + cuit_proveedor
                          + " AND (cantidad_stock BETWEEN " + cantDesde + " AND " + cantHasta + ")";
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarArticulosPorProveedoryStockDesde(string cuit_proveedor, string cantDesde)
        {
            string sql = @"SELECT a.*
                          FROM Articulos a
                          WHERE cuit_proveedor = " + cuit_proveedor
                          + " AND (cantidad_stock >= " + cantDesde + ")";
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarArticulosPorProveedoryStockHasta(string cuit_proveedor, string cantHasta)
        {
            string sql = @"SELECT a.*
                          FROM Articulos a
                          WHERE cuit_proveedor = " + cuit_proveedor
                          + " AND (cantidad_stock <= " + cantHasta + ")";
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarArticulosProveedorPatronyStock(string cuit_proveedor, string patron, string cantDesde, string cantHasta)
        {
            string sql = @"SELECT a.*
                          FROM Articulos a
                          WHERE cuit_proveedor = " + cuit_proveedor
                          + " AND (cantidad_stock BETWEEN " + cantDesde + " AND " + cantHasta + ")"
                          + " AND (nombre_articulo LIKE '%" + patron + "%')";
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarArticulosProveedorPatronyStockDesde(string cuit_proveedor, string patron, string cantDesde)
        {
            string sql = @"SELECT a.*
                          FROM Articulos a
                          WHERE cuit_proveedor = " + cuit_proveedor
                          + " AND (cantidad_stock >= " + cantDesde + ")"
                          + " AND (nombre_articulo LIKE '%" + patron + "%')";
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarArticulosProveedorPatronyStockHasta(string cuit_proveedor, string patron, string cantHasta)
        {
            string sql = @"SELECT a.*
                          FROM Articulos a
                          WHERE cuit_proveedor = " + cuit_proveedor
                          + " AND (cantidad_stock <= " + cantHasta + ")"
                          + " AND (nombre_articulo LIKE '%" + patron + "%')";
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarArticulosProveedorPatron(string cuit_proveedor, string patron)
        {
            string sql = @"SELECT a.*
                          FROM Articulos a
                          WHERE cuit_proveedor = " + cuit_proveedor
                          + " AND (nombre_articulo LIKE '%" + patron + "%')";
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarArticulosPatron(string patron)
        {
            string sql = @"SELECT a.*
                          FROM Articulos a
                          WHERE nombre_articulo LIKE '%" + patron + "%'";
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarArticulosPatronStock(string patron, string cantDesde, string cantHasta)
        {
            string sql = @"SELECT a.*
                          FROM Articulos a
                          WHERE nombre_articulo LIKE '%" + patron + "%'"
                           + " AND (cantidad_stock BETWEEN " + cantDesde + " AND " + cantHasta + ")";
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarArticulosPatronStockDesde(string patron, string cantDesde)
        {
            string sql = @"SELECT a.*
                          FROM Articulos a
                          WHERE nombre_articulo LIKE '%" + patron + "%'"
                          + " AND (cantidad_stock >= " + cantDesde + ")";
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarArticulosPatronStockHasta(string patron, string cantHasta)
        {
            string sql = @"SELECT a.*
                          FROM Articulos a
                          WHERE nombre_articulo LIKE '%" + patron + "%'"
                          + " AND (cantidad_stock <= " + cantHasta + ")";
            return (_BD_T.EjecutarSelect(sql));
        }
    }
}
