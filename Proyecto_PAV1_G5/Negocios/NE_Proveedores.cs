using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_PAV1_G5.BackEnd;
using Proyecto_PAV1_G5.Clases;
using System.Windows.Forms;
using System.Data;

namespace Proyecto_PAV1_G5.Negocios
{
    class NE_Proveedores
    {
        Acceso_Datos _BD = new Acceso_Datos();

        public Estructura_ComboBox DatosComboBarrio()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "id_barrio";
            edc.Display = "nombre_barrio";
            edc.Sql = "SELECT * FROM Barrios ";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        
        //Funcion insertar proveedor
        public void Modificar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Modificar(tratamiento.ConstructorModificar_Sin_PK("Proveedores", ValorPk, controles));
        }

        public void Insertar(Control.ControlCollection controles)
        {
            _BD.Insertar(tratamiento.ConstructorInsertar("Proveedores", controles));
        }

        public void Eliminar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Borrar(tratamiento.ConstructorEliminar("Proveedores", ValorPk, controles));
        }

        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT p.*, b.nombre_barrio as barrio, e.nombre + ' ' + e.apellido as comprador"
                        + " FROM Proveedores p "
                        + "join Barrios b on p.id_barrio = b.id_barrio "
                        +"join Empleados e on e.legajo = p.legajo_comprador";
            return _BD.Ejecutar_Select(sql);
        }
        public DataTable Recuperar_x_Cuit(string patron)
        {
            string sql = @"SELECT c.*, b.nombre_barrio as barrio, e.nombre + ' ' + e.apellido as comprador FROM Proveedores c "
                        + "join Barrios b on c.id_barrio = b.id_barrio "
                        + "join Empleados e on e.legajo = c.legajo_comprador "
                        + "WHERE c.cuit_proveedor like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Cuit_Array(string[] cuit)
        {

            string sql = "SELECT c.* FROM Proveedores c WHERE c.cuit_proveedor = " + cuit[0];
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Razon_Social(string patron)
        {
            string sql = @"SELECT c.*, b.nombre_barrio as barrio, e.nombre + ' ' + e.apellido as comprador FROM Proveedores c "
                        + "join Barrios b on c.id_barrio = b.id_barrio "
                        + "join Empleados e on e.legajo = c.legajo_comprador "
                        + "WHERE c.razon_social like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_Mixto(string patron_cuit, string patron_razon_social)
        {
            string sql = @"SELECT c.*, b.nombre_barrio as barrio, e.nombre + ' ' + e.apellido as comprador FROM Proveedores c "
                        + "join Barrios b on c.id_barrio = b.id_barrio "
                        + "join Empleados e on e.legajo = c.legajo_comprador "
                        + "WHERE c.razon_social like '%" + patron_razon_social.Trim() + "%' AND "
                        + "c.cuit_proveedor like '%" + patron_cuit.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }
    }
}
