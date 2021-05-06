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
    class NE_Equipos_Simples
    {
        // ZONA DE DECLARACIONES
        Acceso_Datos _BD = new Acceso_Datos();
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        public Estructura_ComboBox DatosCombo()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "id_tabla";
            edc.Display = "nombre_a_recuperar";
            edc.Sql = "SELECT * FROM NombreTabla";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;

        }

        // FUNCION INSERTAR UN EQUIPO

        public void Insertar(Control.ControlCollection controles)
        {
            _BD.Insertar(tratamiento.ConstructorInsertar("Equipos", controles));
        }

        public void Modificar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Modificar(tratamiento.ConstructorModificar_Sin_PK("Equipos", ValorPk, controles));
        }

        public void Eliminar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Borrar(tratamiento.ConstructorEliminar("Equipos", ValorPk, controles));
        }

        // RECUPERACION DE DATOS SI NO SE SELECCIONO PATRON
        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT * "
                        + " FROM Equipos "; ;
            return _BD.Ejecutar_Select(sql);
        }

        // RECUPERACION DE DATOS SI SE SELECCIONARON AMBOS PATRONES
        public DataTable Recuperar_Mixto(string codigo, string nombre_equipo)
        {
            string sql = @"SELECT * FROM Equipos "
                        + "WHERE codigo_equipo like '%" + codigo.Trim() + "%' AND "
                        + "nombre_equipo like '%" + nombre_equipo.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        // RECUPERACION DE DATOS SI SE SELECCIONO UNICAMENTE EL CODIGO DEL EQUIPO
        public DataTable Recuperar_x_Codigo_Equipo(string codigo)
        {
            string sql = @"SELECT * FROM Equipos "
                        + "WHERE codigo_equipo like '%" + codigo.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        // RECUPERACION DE DATOS SI SELECCIONO UNICAMENTE EL NOMBRE DEL EQUIPO
        public DataTable Recuperar_x_Nombre(string nombre)
        {
            string sql = @"SELECT * FROM Equipos "
                        + "WHERE nombre_equipo like '%" + nombre.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Codigo_Array(string[] codigo)
        {

            string sql = "SELECT e.* FROM Equipos e WHERE e.codigo_equipo = " + codigo[0];
            return _BD.Ejecutar_Select(sql);
        }
    }
}