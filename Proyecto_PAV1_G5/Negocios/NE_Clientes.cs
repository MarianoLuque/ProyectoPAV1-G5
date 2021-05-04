using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_PAV1_G5.BackEnd;
using Proyecto_PAV1_G5.Clases;
using System.Windows.Forms;

namespace Proyecto_PAV1_G5.Negocios
{
    class NE_Clientes
    {
        //Funcion insertar cliente
        public void Insertar(Control.ControlCollection controles)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
            _BD.Insertar(tratamiento.ConstructorInsert("Clientes", controles));
        }


        //Con esto hicimos el combobox para el barrio
        Acceso_Datos _BD = new Acceso_Datos();
        public Estructura_ComboBox DatosCombo()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "id_barrio";
            edc.Display = "nombre_barrio";
            edc.Sql = "SELECT * FROM Barrios";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;

        }
    }
}
