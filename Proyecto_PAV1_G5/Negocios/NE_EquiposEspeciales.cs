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
    class NE_EquiposEspeciales
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

        // FUNCIONES CONSULTA
        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT * "
                        + " FROM Equipos_Especiales "; ;
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_Cuit_Cliente(string cuit)
        {
            string sql = @"SELECT e.* FROM Equipos_Especiales e "
                        + "WHERE e.cuit_cliente like '%" + cuit.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Codigo_Equipo(string codigo)
        {
            string sql = @"SELECT e.* FROM Equipos_Especiales e "
            + "WHERE e.codigo_equipo_especial like '%" + codigo.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Nombre(string nombre)
        {
            string sql = @"SELECT e.* FROM Equipos_Especiales e "
           + "WHERE e.nombre_equipo_especial like '%" + nombre.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Nombre_y_Codigo(string nombre, string codigo)
        {
            string sql = @"SELECT e.* FROM Equipos_Especiales e "
           + "WHERE e.nombre_equipo_especial like '%" + nombre.Trim() + "%' AND e.codigo_equipo_especial like '%"+ codigo.Trim() + "%'" ;
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Nombre_y_Cuit(string nombre, string cuit)
        {
            string sql = @"SELECT e.* FROM Equipos_Especiales e "
           + "WHERE e.nombre_equipo_especial like '%" + nombre.Trim() + "%' AND e.cuit_cliente like '%" + cuit.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Cuit_y_Codigo(string cuit, string codigo)
        {
            string sql = @"SELECT e.* FROM Equipos_Especiales e "
           + "WHERE e.cuit_cliente like '%" + cuit.Trim() + "%' AND e.codigo_equipo_especial like '%" + codigo.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Cuit_y_Nombre(string cuit, string nombre)
        {
            string sql = @"SELECT e.* FROM Equipos_Especiales e "
           + "WHERE e.cuit_cliente like '%" + cuit.Trim() + "%' AND e.nombre_equipo_especial like '%" + nombre.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Cuit_Nombre_y_Codigo(string cuit, string nombre, string codigo)
        {
            string sql = @"SELECT e.* FROM Equipos_Especiales e "
           + "WHERE e.cuit_cliente like '%" + cuit.Trim() + "%' AND e.nombre_equipo_especial like '%" + nombre.Trim() + "%' AND e.codigo_equipo_especial like '%" + codigo.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }


        public string ConstructorSelect(Control.ControlCollection controles, string tabla)
        {
            string sql = $"SELECT * FROM {tabla} ";
            string condiciones = "";
            foreach (var item in controles)
            {
                if (item.GetType().ToString() == "Proyecto_PAV1_G5.TextBox01")
                {
                    TextBox01 txt = (TextBox01)item;
                    if (txt.Text != "")
                    {
                        if (condiciones == "")
                        {
                            sql += $"WHERE {txt.Pp_campo}={tratamiento.FormatearIntString(txt.Text)}";
                        }
                        else
                        {
                            sql += $" AND {txt.Pp_campo}={tratamiento.FormatearIntString(txt.Text)}";
                        }
                    }

                }
            }
            return sql;
        }

        public void Insertar(Control.ControlCollection controles)
        {
            Acceso_Datos _BD = new Acceso_Datos();
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
            _BD.Insertar(tratamiento.ConstructorInsertar("Equipos_Especiales", controles));
        }

        public void Modificar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Modificar(tratamiento.ConstructorModificar_Sin_PK("Equipos_Especiales", ValorPk, controles));
        }

        public void Eliminar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Borrar(tratamiento.ConstructorEliminar("Equipos_Especiales", ValorPk, controles));
        }
        public DataTable Recuperar_x_Codigo_y_Cuit_Array(string[] Pp_codigo_y_cuit)
        {
            string sql = "SELECT e.* FROM Equipos_Especiales e WHERE e.codigo_equipo_especial = " + Pp_codigo_y_cuit[0] + " AND e.cuit_cliente = " + Pp_codigo_y_cuit[1];
            return _BD.Ejecutar_Select(sql);
        }
    }
}
