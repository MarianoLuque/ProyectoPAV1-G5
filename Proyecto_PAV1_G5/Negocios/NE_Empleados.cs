using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAV1_G5.BackEnd;
using Proyecto_PAV1_G5.Clases;

namespace Proyecto_PAV1_G5.Negocios
{
    class NE_Empleados
    {
        Acceso_Datos _BD = new Acceso_Datos();

        public Estructura_ComboBox DatosComboTipoDoc()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "id_tipo_documento";
            edc.Display = "nombre_tipo_documento";
            edc.Sql = "SELECT * FROM Tipo_Documento";

            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;

        }
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
        //Funcion insertar cliente
        public void Modificar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Modificar(tratamiento.ConstructorModificar_Con_PK("Empleados", ValorPk, controles));
        }

        public void Insertar(Control.ControlCollection controles)
        {
            _BD.Insertar(tratamiento.ConstructorInsertar("Empleados", controles));
        }

        public void Eliminar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Borrar(tratamiento.ConstructorEliminar("Empleados", ValorPk, controles));
        }

        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT e.*, b.nombre_barrio as barrio, d.nombre_tipo_documento as documento"
                        + " FROM Empleados e "
                        + "join Barrios b on e.id_barrio = e.id_barrio "
                        + "join Tipo Documento d on d.id_tipo_documento = e.id_tipo_documento";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Legajo(string patron)
        {
            string sql = @"SELECT e.*, b.nombre_barrio as barrio, d.nombre_tipo_documento as documento"
                        + " FROM Empleados e "
                        + "join Barrios b on e.id_barrio = e.id_barrio "
                        + "join Tipo Documento d on d.id_tipo_documento = e.id_tipo_documento "
                        + "WHERE e.legajo like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Tipo_Documento(string id_tipo_documento)
        {
            string sql = @"SELECT e.*, b.nombre_barrio as barrio, d.nombre_tipo_documento as documento"
                        + " FROM Empleados e "
                        + "join Barrios b on e.id_barrio = e.id_barrio "
                        + "join Tipo Documento d on d.id_tipo_documento = e.id_tipo_documento "
                        + "WHERE e.id_tipo_documento = " + id_tipo_documento;
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Numero_Documento(string numero_documento)
        {
            string sql = @"SELECT e.*, b.nombre_barrio as barrio, d.nombre_tipo_documento as documento"
                        + " FROM Empleados e "
                        + "join Barrios b on e.id_barrio = e.id_barrio "
                        + "join Tipo Documento d on d.id_tipo_documento = e.id_tipo_documento "
                        + "WHERE e.nro_documento like '%" + numero_documento.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Apellido(string apellido)
        {
            string sql = @"SELECT e.*, b.nombre_barrio as barrio, d.nombre_tipo_documento as documento"
                        + " FROM Empleados e "
                        + "join Barrios b on e.id_barrio = e.id_barrio "
                        + "join Tipo Documento d on d.id_tipo_documento = e.id_tipo_documento "
                        + "WHERE e.apellido like '%" + apellido.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Tipo_y_Numero_Documento(string numero_documento, string id_tipo_documento)
        {
            string sql = @"SELECT e.*, b.nombre_barrio as barrio, d.nombre_tipo_documento as documento"
                        + " FROM Empleados e "
                        + "join Barrios b on e.id_barrio = e.id_barrio "
                        + "join Tipo Documento d on d.id_tipo_documento = e.id_tipo_documento "
                        + "WHERE e.nro_documento like '%" + numero_documento.Trim() + "%' AND "
                        + "e.id_tipo_documento = " + id_tipo_documento;
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Tipo_Documento_y_Legajo(string legajo, string id_tipo_documento)
        {
            string sql = @"SELECT e.*, b.nombre_barrio as barrio, d.nombre_tipo_documento as documento"
                        + " FROM Empleados e "
                        + "join Barrios b on e.id_barrio = e.id_barrio "
                        + "join Tipo Documento d on d.id_tipo_documento = e.id_tipo_documento "
                        + "WHERE e.legajo like '%" + legajo.Trim() + "%' AND "
                        + "e.id_tipo_documento = " + id_tipo_documento;
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Tipo_Documento_y_Apellido(string apellido, string id_tipo_documento)
        {
            string sql = @"SELECT e.*, b.nombre_barrio as barrio, d.nombre_tipo_documento as documento"
                        + " FROM Empleados e "
                        + "join Barrios b on e.id_barrio = e.id_barrio "
                        + "join Tipo Documento d on d.id_tipo_documento = e.id_tipo_documento "
                        + "WHERE e.apellido like '%" + apellido.Trim() + "%' AND "
                        + "e.id_tipo_documento = " + id_tipo_documento;
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Numero_Documento_y_Legajo(string numero_documento, string legajo)
        {
            string sql = @"SELECT e.*, b.nombre_barrio as barrio, d.nombre_tipo_documento as documento"
                        + " FROM Empleados e "
                        + "join Barrios b on e.id_barrio = e.id_barrio "
                        + "join Tipo Documento d on d.id_tipo_documento = e.id_tipo_documento "
                        + "WHERE e.nro_documento like '%" + numero_documento.Trim() + "%' AND "
                        + "e.legajo like '%" + legajo.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Numero_Documento_y_Apellido(string numero_documento, string apellido)
        {
            string sql = @"SELECT e.*, b.nombre_barrio as barrio, d.nombre_tipo_documento as documento"
                        + " FROM Empleados e "
                        + "join Barrios b on e.id_barrio = e.id_barrio "
                        + "join Tipo Documento d on d.id_tipo_documento = e.id_tipo_documento "
                        + "WHERE e.nro_documento like '%" + numero_documento.Trim() + "%' AND "
                        + "e.apellido like '%" + apellido.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Apellido_y_Legajo(string apellido, string legajo)
        {
            string sql = @"SELECT e.*, b.nombre_barrio as barrio, d.nombre_tipo_documento as documento"
                        + " FROM Empleados e "
                        + "join Barrios b on e.id_barrio = e.id_barrio "
                        + "join Tipo Documento d on d.id_tipo_documento = e.id_tipo_documento "
                        + "WHERE e.apellido like '%" + apellido.Trim() + "%' AND "
                        + "e.legajo like '%" + legajo.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

    }
}
