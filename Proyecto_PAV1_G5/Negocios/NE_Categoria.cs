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
    class NE_Categoria
    {
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

        // MODIFICAR
        public void Modificar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Modificar(tratamiento.ConstructorModificar_Sin_PK("Clasificacion_Clientes", ValorPk, controles));
        }

        // INSERTAR
        public void Insertar(Control.ControlCollection controles)
        {
            _BD.Insertar(tratamiento.ConstructorInsertar("Clasificacion_Clientes", controles));
        }

        // ELIMINAR
        public void Eliminar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Borrar(tratamiento.ConstructorEliminar("Clasificacion_Clientes", ValorPk, controles));
        }

        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT cc.* FROM Clasificacion_Clientes cc ";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_cantidad_compras(string cantidad)
        {
            string sql = @"SELECT cc.* FROM Clasificacion_Clientes cc "
                        + " WHERE cc.cantidad_compras_historicas = "+ cantidad.Trim();
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_antiguedad(string antiguedad)
        {
            string sql = @"SELECT cc.* FROM Clasificacion_Clientes cc "
                        + " WHERE cc.anios_antiguedad = " + antiguedad.Trim();
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_antiguedad_y_cantidad_compras(string antiguedad, string cantidad)
        {
            string sql = @"SELECT cc.* FROM Clasificacion_Clientes cc "
                        + " WHERE cc.anios_antiguedad = " + antiguedad.Trim() + " AND cc.cantidad_compras_historicas = " + cantidad.Trim();
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_ID_Categoria_Array(string[] id_categoria)
        {
            string sql = "SELECT cc.* FROM Clasificacion_Clientes cc WHERE cc.id_clasificacion = " + id_categoria[0];
            return _BD.Ejecutar_Select(sql);
        }
    }
}
