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
    class NE_Compras
    {
        Acceso_Datos _BD = new Acceso_Datos();
        Acceso_Datos_T _BD_T = new Acceso_Datos_T();
        public Estructura_ComboBox DatosComboArticulo(string id_rubro)
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "codigo_articulo";
            edc.Display = "nombre_articulo";
            edc.Sql = "SELECT * FROM Articulos a JOIN Rubros_X_Articulo ra ON a.codigo_articulo = ra.codigo_articulo WHERE ra.id_rubro = " + id_rubro;
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

        //Numero de Remito; Cuit Proveedor; Razon Social Proveedor; Fecha Recepción

        public DataTable RecuperarTodos()
        {
            string Sql = @"SELECT rp.nro_remito, rp.cuit_proveedor, p.razon_social, rp.fecha_recepcion FROM Remitos_Proveedores rp 
                           JOIN Proveedores p ON rp.cuit_proveedor = p.cuit_proveedor";
            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_X_Proveedor(string cuit)
        {
            string Sql = @"SELECT rp.nro_remito, rp.cuit_proveedor, p.razon_social, rp.fecha_recepcion FROM Remitos_Proveedores rp 
                           JOIN Proveedores p ON rp.cuit_proveedor = p.cuit_proveedor
                           WHERE rp.cuit_proveedor = " + cuit;
            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_X_Fecha_Desde(string fecha)
        {
            string Sql = @"SELECT rp.nro_remito, rp.cuit_proveedor, p.razon_social, rp.fecha_recepcion FROM Remitos_Proveedores rp 
                           JOIN Proveedores p ON rp.cuit_proveedor = p.cuit_proveedor
                           WHERE rp.fecha_recepcion >= Convert (Date, '" + fecha + "', 103)";
            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_X_Fecha_Hasta(string fecha)
        {
            string Sql = @"SELECT rp.nro_remito, rp.cuit_proveedor, p.razon_social, rp.fecha_recepcion FROM Remitos_Proveedores rp 
                           JOIN Proveedores p ON rp.cuit_proveedor = p.cuit_proveedor
                           WHERE rp.fecha_recepcion <= Convert (Date, '" + fecha + "', 103)";
            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_X_Proveedor_Y_Fecha_Desde(string cuit, string fecha)
        {
            string Sql = @"SELECT rp.nro_remito, rp.cuit_proveedor, p.razon_social, rp.fecha_recepcion FROM Remitos_Proveedores rp 
                           JOIN Proveedores p ON rp.cuit_proveedor = p.cuit_proveedor
                           WHERE rp.fecha_recepcion >= Convert (Date, '" + fecha + "', 103) AND rp.cuit_proveedor = " + cuit;
            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_X_Proveedor_Y_Fecha_Hasta(string cuit, string fecha)
        {
            string Sql = @"SELECT rp.nro_remito, rp.cuit_proveedor, p.razon_social, rp.fecha_recepcion FROM Remitos_Proveedores rp 
                           JOIN Proveedores p ON rp.cuit_proveedor = p.cuit_proveedor
                           WHERE rp.fecha_recepcion <= Convert (Date, '" + fecha + "', 103) AND rp.cuit_proveedor = " + cuit;
            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_X_Fecha_Desde_Y_Hasta(string fecha_desde, string fecha_hasta)
        {
            string Sql = @"SELECT rp.nro_remito, rp.cuit_proveedor, p.razon_social, rp.fecha_recepcion FROM Remitos_Proveedores rp 
                           JOIN Proveedores p ON rp.cuit_proveedor = p.cuit_proveedor
                           WHERE rp.fecha_recepcion >= Convert(Date, '" + fecha_desde + "', 103) AND rp.fecha_recepcion <= Convert (Date, '" + fecha_hasta + "', 103)";
            return (_BD.Ejecutar_Select(Sql));
        }

        public DataTable Recuperar_X_Proveedor_Y_Fecha_Desde_Y_Hasta(string cuit, string fecha_desde, string fecha_hasta)
        {
            string Sql = @"SELECT rp.nro_remito, rp.cuit_proveedor, p.razon_social, rp.fecha_recepcion FROM Remitos_Proveedores rp 
                           JOIN Proveedores p ON rp.cuit_proveedor = p.cuit_proveedor
                           WHERE rp.fecha_recepcion >=  Convert(Date, '" + fecha_desde + "', 103) AND rp.fecha_recepcion <= Convert (Date, '" + fecha_hasta + "', 103) AND rp.cuit_proveedor = " + cuit;
            return (_BD.Ejecutar_Select(Sql));
        }

        public string RecuperarNroRemito()
        {
            string sql = "SELECT MAX(nro_remito) FROM Remitos_Proveedores";
            DataTable tabla = _BD.Ejecutar_Select(sql);
            if (tabla.Rows[0][0].ToString() == "")
            {
                return "1";
            }
            else
            {
                return (int.Parse(tabla.Rows[0][0].ToString()) + 1).ToString();
            }
        }

        public string RecuperarNroLote()
        {
            string sql = "SELECT MAX(nro_lote) FROM Lotes";
            DataTable tabla = _BD.Ejecutar_Select(sql);
            if (tabla.Rows[0][0].ToString() == "")
            {
                return "1";
            }
            else
            {
                return (int.Parse(tabla.Rows[0][0].ToString()) + 1).ToString();
            }
        }

        public string RecuperarNroSerie()
        {
            string sql = "SELECT MAX(nro_serie) FROM Articulos_X_Lote";
            DataTable tabla = _BD.Ejecutar_Select(sql);
            if (tabla.Rows[0][0].ToString() == "")
            {
                return "1";
            }
            else
            {
                return (int.Parse(tabla.Rows[0][0].ToString()) + 1).ToString();
            }
        }

        public string RecuperarFechaRecepcion(string codigo_articulo)
        {
            string sql = "SELECT tiempo_envio FROM Articulos WHERE codigo_articulo = " + codigo_articulo;
            DataTable tabla = _BD_T.EjecutarSelect(sql);
            string sqlFecha = "SELECT DATEADD(DAY, " + tabla.Rows[0][0].ToString() + ", GETDATE())";
            return (_BD_T.EjecutarSelect(sqlFecha).Rows[0][0].ToString());
        }

        public void InsertarCompra(Grid01 grid_articulos, string cuit_proveedor)
        {
            string nro_remito = RecuperarNroRemito();
            string sqlRemitos_Proveedores = "INSERT INTO Remitos_Proveedores (nro_remito, fecha_recepcion, cuit_proveedor) VALUES ("
                        + nro_remito + ", CONVERT(DATE, '" + RecuperarFechaRecepcion(grid_articulos.Rows[0].Cells[0].Value.ToString()) + "', 103), " + cuit_proveedor + ")";

            _BD_T.InicioTransaccion();
            _BD_T.Insertar(sqlRemitos_Proveedores);

            for (int i = 0; i < grid_articulos.Rows.Count; i++)
            {
                string sqlArticulos_X_Remito = "INSERT INTO Articulos_X_Remito (codigo_articulo, nro_remito, cantidad) VALUES ("
                                           + grid_articulos.Rows[i].Cells[0].Value.ToString() + ", " + nro_remito + ", " + grid_articulos.Rows[i].Cells[4].Value.ToString() + ")";

                _BD_T.Insertar(sqlArticulos_X_Remito);
            }
            string nro_lote = RecuperarNroLote();
            string sqlLotes = "INSERT INTO Lotes (nro_lote, fecha_compra, nro_remito) VALUES (" + nro_lote + ", CONVERT(date, GETDATE(), 103), " + nro_remito + ")";

            _BD_T.Insertar(sqlLotes);
            for (int i = 0; i < grid_articulos.Rows.Count; i++)
            {
                string sqlArticulos_X_Lote = "INSERT INTO Articulos_X_Lote (codigo_articulo, nro_lote, nro_serie) VALUES ("
                                            + grid_articulos.Rows[i].Cells[0].Value.ToString() + ", " + nro_lote + ", " + RecuperarNroSerie() + ")";

                _BD_T.Insertar(sqlArticulos_X_Lote);
            }
            if (_BD_T.FinalTransaccion() == Acceso_Datos_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se grabó correctamente todo");
                ActualizarCantidadStockArt(grid_articulos);

            }
            else
            {
                MessageBox.Show("No se grabó nada por un error");
            }

        }

        public void ActualizarCantidadStockArt(Grid01 grid_articulos)
        {
            string sql = "";
            for (int i = 0; i < grid_articulos.Rows.Count; i++)
            {
                sql = "UPDATE Articulos SET cantidad_stock += " + grid_articulos.Rows[i].Cells[4].Value.ToString() + " WHERE codigo_articulo = " + grid_articulos.Rows[i].Cells[0].Value.ToString();
                _BD.Modificar(sql);
            }

        }

        public DataTable RecuperarArticulo(string codigo)
        {
            string sql = "SELECT * FROM Articulos WHERE codigo_articulo = " + codigo;
            return (_BD.Ejecutar_Select(sql));
        }

        public DataTable RecuperarArticulos_X_Remito(string nro_remito)
        {
            string sql = " SELECT ra.codigo_articulo, a.nombre_articulo, ra.id_rubro, r.nombre_rubro, ar.cantidad FROM Remitos_Proveedores rp" 
                        +" JOIN Articulos_X_Remito ar ON rp.nro_remito = ar.nro_remito"
                        +" JOIN Articulos a ON ar.codigo_articulo = a.codigo_articulo"
                        +" JOIN Rubros_X_Articulo ra ON a.codigo_articulo = ra.codigo_articulo"
                        +" JOIN Rubros r ON ra.id_rubro = r.id_rubro"
                        +" WHERE rp.nro_remito = " + nro_remito;
            return(_BD_T.EjecutarSelect(sql));
        }
    }
}
