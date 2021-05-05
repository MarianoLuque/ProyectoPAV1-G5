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
    class NE_Clientes
    {
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        //Funcion insertar cliente
        public void Modificar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Modificar(tratamiento.ConstructorModificar("Clientes", ValorPk, controles));
        }

        public void Insertar(Control.ControlCollection controles)
        {
            _BD.Insertar(tratamiento.ConstructorInsertar("Clientes", controles));
        }

        public void Eliminar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Borrar(tratamiento.ConstructorEliminar("Clientes", ValorPk, controles));
        }

        //Con esto hicimos el combobox para el barrio
        Acceso_Datos _BD = new Acceso_Datos();
        public Estructura_ComboBox DatosCombo()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "id_barrio";
            edc.Display = "nombre_barrio";
            edc.Sql = "SELECT * FROM Barrios ";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;

        }

        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT c.*, b.nombre_barrio as barrio, e.nombre + ' ' + e.apellido as vendedor_asignado" 
                        + " FROM Clientes c "
                        + "join Barrios b on c.id_barrio = b.id_barrio "
                        + "join Empleados e on e.legajo = c.legajo_vendedor_asignado";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Cuit(string patron)
        {
            string sql = @"SELECT c.*, b.nombre_barrio as barrio, e.nombre + ' ' + e.apellido as vendedor_asignado FROM Clientes c "
                        + "join Barrios b on c.id_barrio = b.id_barrio "
                        + "join Empleados e on e.legajo = c.legajo_vendedor_asignado "
                        + "WHERE c.cuit_clientes like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Cuit_Array(string[] cuit)
        {

            string sql = "SELECT c.* FROM Clientes c WHERE c.cuit_clientes = " + cuit[0];
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Razon_Social(string patron)
        {
            string sql = @"SELECT c.*, b.nombre_barrio as barrio, e.nombre + ' ' + e.apellido as vendedor_asignado FROM Clientes c "
                        + "join Barrios b on c.id_barrio = b.id_barrio "
                        + "join Empleados e on e.legajo = c.legajo_vendedor_asignado "
                        + "WHERE c.razon_social like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_Mixto(string patron_cuit, string patron_razon_social)
        {
            string sql = @"SELECT c.*, b.nombre_barrio as barrio, e.nombre + ' ' + e.apellido as vendedor_asignado FROM Clientes c "
                        + "join Barrios b on c.id_barrio = b.id_barrio "
                        + "join Empleados e on e.legajo = c.legajo_vendedor_asignado "
                        + "WHERE c.razon_social like '%" + patron_razon_social.Trim() + "%' AND "
                        + "c.cuit_clientes like '%" + patron_cuit.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

    }
}
