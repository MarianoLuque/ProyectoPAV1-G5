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
    class NE_Ventas
    {
        Acceso_Datos _BD = new Acceso_Datos();
        public Estructura_ComboBox DatosComboCliente()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "cuit_cliente";
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

        //Numero Factura; Tipo Factura; Cuit Cliente; Monto Total; Fecha de Venta; Vendedor Asignado; Forma de Pago

        public DataTable RecuperarTodos()
        {
            string Sql = "SELECT f.nro_factura, tf.nombre_tipo_factura, f.monto_total, f.fecha_venta, (e.nombre + ' ' + e.apellido) as Vendedor_Asignado, fp.nombre_forma_pago FROM Facturas f " +
                         "JOIN Tipos_Facturas tf ON f.id_tipo_factura = tf.id_tipo_factura " +
                         "JOIN Empleados e ON f.legajo_vendedor = e.legajo " +
                         "JOIN Formas_De_Pago fp ON f.id_forma_pago = fp.id_forma_pago";

            return (_BD.Ejecutar_Select(Sql));
        }
    }
}
