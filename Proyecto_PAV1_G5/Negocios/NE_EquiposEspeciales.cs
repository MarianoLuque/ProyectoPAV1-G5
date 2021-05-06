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
    }
}
