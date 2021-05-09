using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto_PAV1_G5.BackEnd;

namespace Proyecto_PAV1_G5.Login
{
    class NE_Login
    {
        // Z O N A    D E    D E C L A R A C I O N E S 
        public enum ResultadoValidacion { existe, no_existe }
        DataTable tabla = new DataTable();
        Acceso_Datos _BD = new Acceso_Datos();
        public ResultadoValidacion Validar_Usuario(String usuario, String password)
        {
            String sql = @"SELECT * FROM Empleados WHERE usuario = '" + usuario + "'"
                                + "AND contrasena = '" + password + "'"; // comando que va a ejecutar
            tabla = _BD.Ejecutar_Select(sql); //la ejecucion de este comando me devuelve un DataTable

            if (tabla.Rows.Count == 1)
            {
                return ResultadoValidacion.existe;
            }
            else
            {
                return ResultadoValidacion.no_existe;
            }
        }

    }
}
