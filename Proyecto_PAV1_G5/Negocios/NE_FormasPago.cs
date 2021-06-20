using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_PAV1_G5.BackEnd;
using Proyecto_PAV1_G5.Clases;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_PAV1_G5.Negocios
{
    class NE_FormasPago
    {
        // ZONA DE DECLARACIONES
        Acceso_Datos _BD = new Acceso_Datos();
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

        // RECUPERAR TODAS LAS FORMAS DE PAGO
        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT fp.* FROM Formas_De_Pago fp";
            return _BD.Ejecutar_Select(sql);
        }

        // RECUPERAR FORMA DE PAGO CON PATRON NOMBRE
        public DataTable Recuperar_x_nombre(string nombre)
        {
            string sql = @"SELECT fp.* FROM Formas_De_Pago fp "
                        + "WHERE fp.nombre_forma_pago like '%" + nombre.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        // RECUPERAR EL ID DE ESA CELDA
        public DataTable Recuperar_x_ID_Forma_Pago_Array(string[] id_forma_pago)
        {
            string sql = "SELECT fp.* FROM Formas_De_Pago fp WHERE fp.id_forma_pago = " + id_forma_pago[0];
            return _BD.Ejecutar_Select(sql);
        }

        // INSERTAR
        public void Insertar(Control.ControlCollection controles)
        {
            _BD.Insertar(tratamiento.ConstructorInsertar("Formas_De_Pago", controles));
        }

        // MODIFICAR
        public void Modificar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Modificar(tratamiento.ConstructorModificar_Con_PK("Formas_De_Pago", ValorPk, controles));
        }

        // ELIMINAR
        public void Eliminar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Borrar(tratamiento.ConstructorEliminar("Formas_De_Pago", ValorPk, controles));
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

        public DataTable ReporteFormaDePago(bool rb1, bool rb2, bool rb3, string fecha, string tipo_factura)
        {
            string condicion = "";
            if(rb1)
            {
                string[] subcadenasFecha = fecha.Split('/');
                string mes = subcadenasFecha[1];
                string anio = subcadenasFecha[2];
                condicion = " AND (MONTH(f.fecha_venta) = " + mes + " AND YEAR(f.fecha_venta) = " + anio + ")";
            }

            if(rb2)
            {
                condicion = " AND f.id_tipo_factura = " + tipo_factura;
            }

            if (rb3)
            {
                string[] subcadenasFecha = fecha.Split('/');
                string mes = subcadenasFecha[1];
                string anio = subcadenasFecha[2];

                condicion = " AND (MONTH(f.fecha_venta) = " + mes + " AND YEAR(f.fecha_venta) = " + anio + ") AND f.id_tipo_factura = " + tipo_factura;
            }

            string sql = "SELECT fp.nombre_forma_pago, COUNT(*) as cantidad FROM Formas_De_Pago fp " +
                         "JOIN Facturas f on f.id_forma_pago = fp.id_forma_pago " +
                         "WHERE 1 = 1 " + condicion +
                         " GROUP BY fp.nombre_forma_pago ";

            return _BD.Ejecutar_Select(sql);
        }

    }
}
