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
            string sql = @"SELECT p.*, b.nombre_barrio as barrio"
                        + " FROM Proveedores p "
                        + "join Barrios b on p.id_barrio = b.id_barrio ";
            return _BD.Ejecutar_Select(sql);
        }
    }
}
