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
        public Estructura_ComboBox DatosCombo()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "id_pais";
            edc.Display = "nombre_pais";
            edc.Sql = "SELECT * FROM Paises";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;

        }

        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

        public void Insertar(Control.ControlCollection controles)
        {
            _BD.Insertar(tratamiento.ConstructorInsertar("Articulos", controles));
        }

        public void Modificar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Modificar(tratamiento.ConstructorModificar("Articulos", ValorPk, controles));
        }

        public void Eliminar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Borrar(tratamiento.ConstructorEliminar("Articulos", ValorPk, controles));
        }

        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT a.*, p.razon_social"
                        + " FROM Articulos a "
                        + " join Proveedores p on p.cuit_proveedor = a.cuit_proveedor";
            return _BD.Ejecutar_Select(sql);
        }
        public DataTable Recuperar_x_Codigo(string patron)
        {
            string sql = @"SELECT a.*, p.razon_social"
                        + " FROM Articulos a "
                        + " join Proveedores p on p.cuit_proveedor = a.cuit_proveedor"
                        + " WHERE a.codigo_articulo like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Nombre(string patron)
        {
            string sql = @"SELECT a.*, p.razon_social"
                        + " FROM Articulos a "
                        + " join Proveedores p on p.cuit_proveedor = a.cuit_proveedor"
                        + " WHERE a.nombre_articulo like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_Mixto(string patron_codigo, string patron_nombre)
        {
            string sql = @"SELECT a.*, p.razon_social"
                        + " FROM Articulos a "
                        + " join Proveedores p on p.cuit_proveedor = a.cuit_proveedor"
                        + " WHERE a.codigo_articulo like '%" + patron_codigo.Trim() + "%' AND"
                        + " a.nombre_articulo like '%" + patron_nombre.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable RecuperarCodigo(string[] codigo)
        {

            string sql = "SELECT a.* FROM Articulos a WHERE a.codigo_articulo = " + codigo[0];
            return _BD.Ejecutar_Select(sql);
        }

    }
}
