using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_PAV1_G5.BackEnd;
using Proyecto_PAV1_G5.Clases;
using System.Data;

namespace Proyecto_PAV1_G5.Negocios
{
    class NE_Rubros
    {
        Acceso_Datos _BD = new Acceso_Datos();

        public Estructura_ComboBox DatosCombo()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "id_tabla";
            edc.Display = "nombre_a_recuperar";
            edc.Sql = "SELECT * FROM NombreTabla";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;

        }

        public DataTable Recuperar_x_Nombre(string nombre_rubro)
        {
            string sql = @"SELECT r.* FROM Rubros r "
                        + "WHERE r.nombre_rubro like '%" + nombre_rubro.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Id_Rubro_Array(string[] id_rubro)
        {

            string sql = "SELECT r.* FROM Rubros r WHERE r.id_rubro = " + id_rubro[0];
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT r.* FROM Rubros r ";
            return _BD.Ejecutar_Select(sql);
        }
    }
}
