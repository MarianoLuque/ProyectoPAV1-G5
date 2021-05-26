using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_PAV1_G5.Clases;
using Proyecto_PAV1_G5.BackEnd;
using System.Data;

namespace Proyecto_PAV1_G5.Negocios
{
    class NE_Compras
    {
        Acceso_Datos _BD = new Acceso_Datos();
        public Estructura_ComboBox DatosCombo()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "cuit_proveedor";
            edc.Display = "razon_social";
            edc.Sql = "SELECT * FROM Proveedores";
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
    }
}
