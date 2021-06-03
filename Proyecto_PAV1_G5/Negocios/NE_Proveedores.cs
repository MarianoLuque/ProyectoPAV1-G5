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
        Acceso_Datos_T _BD_T = new Acceso_Datos_T();

        public Estructura_ComboBox DatosComboBarrio()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "id_barrio";
            edc.Display = "nombre_barrio";
            edc.Sql = "SELECT * FROM Barrios ";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        public Estructura_ComboBox DatosComboEmpleado()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "legajo";
            edc.Display = "vendedor";
            edc.Sql = "SELECT *, (nombre + ' ' + apellido) as vendedor FROM Empleados";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }

        public Estructura_ComboBox DatosComboRubros()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "id_rubro";
            edc.Display = "nombre_rubro";
            edc.Sql = "SELECT * FROM Rubros ";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;
        }
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

        //Funcion insertar proveedor
        public void Modificar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Modificar(tratamiento.ConstructorModificar_Sin_PK("Proveedores", ValorPk, controles));
        }


        public void Eliminar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Borrar(tratamiento.ConstructorEliminar("Proveedores", ValorPk, controles));
        }

        public DataTable RecuperarRubrosProveedor(string cuit_proveedor)
        {
            string sql = "SELECT rp.id_rubro, r.nombre_rubro, r.descripcion FROM Rubros_X_Proveedor rp " +
                         "JOIN Rubros r ON rp.id_rubro = r.id_rubro WHERE cuit_proveedor = " + cuit_proveedor;
            return (_BD_T.EjecutarSelect(sql));
        }

        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT p.*, b.nombre_barrio as barrio, e.nombre + ' ' + e.apellido as comprador"
                        + " FROM Proveedores p "
                        + "join Barrios b on p.id_barrio = b.id_barrio "
                        + "join Empleados e on e.legajo = p.legajo_comprador";
            return _BD.Ejecutar_Select(sql);
        }
        public DataTable Recuperar_x_Cuit(string patron)
        {
            string sql = @"SELECT c.*, b.nombre_barrio as barrio, e.nombre + ' ' + e.apellido as comprador FROM Proveedores c "
                        + "join Barrios b on c.id_barrio = b.id_barrio "
                        + "join Empleados e on e.legajo = c.legajo_comprador "
                        + "WHERE c.cuit_proveedor like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Cuit_Array(string[] cuit)
        {

            string sql = "SELECT c.* FROM Proveedores c WHERE c.cuit_proveedor = " + cuit[0];
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_x_Razon_Social(string patron)
        {
            string sql = @"SELECT c.*, b.nombre_barrio as barrio, e.nombre + ' ' + e.apellido as comprador FROM Proveedores c "
                        + "join Barrios b on c.id_barrio = b.id_barrio "
                        + "join Empleados e on e.legajo = c.legajo_comprador "
                        + "WHERE c.razon_social like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public DataTable Recuperar_Mixto(string patron_cuit, string patron_razon_social)
        {
            string sql = @"SELECT c.*, b.nombre_barrio as barrio, e.nombre + ' ' + e.apellido as comprador FROM Proveedores c "
                        + "join Barrios b on c.id_barrio = b.id_barrio "
                        + "join Empleados e on e.legajo = c.legajo_comprador "
                        + "WHERE c.razon_social like '%" + patron_razon_social.Trim() + "%' AND "
                        + "c.cuit_proveedor like '%" + patron_cuit.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        public void InsertarRubros(Control.ControlCollection controles)
        {
            _BD_T.Insertar(tratamiento.ConstructorInsertar("Rubros", controles));
        }

        public void InsertarProveedor(Grid01 grid_rubros, string cuit_proveedor, string razon_social, string legajo_comprador, string fecha_inicio_operacion, string telefono, string id_barrio, string calle, string nro_calle)
        {
            string SqlInsertar = @"INSERT INTO Proveedores ( cuit_proveedor, razon_social, legajo_comprador, fecha_inicio_operacion, telefono, id_barrio, calle, nro_calle) VALUES ("
               + cuit_proveedor + ", '" + razon_social + "' , " + legajo_comprador + ", '" + fecha_inicio_operacion + "', " + telefono + " , " + id_barrio + " , '" + calle + "' , " + nro_calle + " )";

            _BD_T.InicioTransaccion();
            _BD_T.Insertar(SqlInsertar);
            InsertarRubros_X_Proveedor(grid_rubros, cuit_proveedor);
            if (_BD_T.FinalTransaccion() == Acceso_Datos_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se registró el proveedor correctamente");
            }
            else
            {
                MessageBox.Show("No se registró el proveedor por un error");
            }

        }
        public void InsertarRubros_X_Proveedor(Grid01 grid_rubros, string cuit_proveedor)
        {

            string sqlRubro = "INSERT INTO Rubros_X_Proveedor (cuit_proveedor, id_rubro) VALUES (" + cuit_proveedor;
            for (int i = 0; i < grid_rubros.Rows.Count; i++)
            {
                string sql = ", " + grid_rubros.Rows[i].Cells[0].Value.ToString();
                _BD_T.Insertar(sqlRubro + sql + ")");
            }
        }

        public void EliminarProveedor(string cuit)
        {
            string sqlProveedor = "DELETE FROM Proveedores WHERE cuit_proveedor = " + cuit;
            string sqlRubro = "DELETE FROM Rubros_X_Proveedor WHERE cuit_proveedor = " + cuit;

            _BD_T.InicioTransaccion();
            _BD_T.Borrar(sqlRubro);
            _BD_T.Borrar(sqlProveedor);
            if (_BD_T.FinalTransaccion() == Acceso_Datos_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se eliminó el proveedor correctamente");
            }
            else
            {
                MessageBox.Show("No se eliminó el proveedor por un error");
            }
        }

        public void ModificarProveedor(Grid01 grid_rubros, string cuit_proveedor, string razon_social, string legajo_comprador, string fecha_inicio_operacion, string telefono, string id_barrio, string calle, string nro_calle)
        {
            string sql = "UPDATE Proveedores SET cuit_proveedor = " + cuit_proveedor + ", razon_social = '" + razon_social + "', legajo_comprador = " + legajo_comprador + ", fecha_inicio_operacion = CONVERT(DATE, '" + fecha_inicio_operacion + "', 103), telefono = " + telefono + ", id_barrio = " + id_barrio + ", calle = '" + calle + "', nro_calle = " + nro_calle;
            _BD_T.InicioTransaccion();
            _BD_T.Modificar(sql);
            for (int i = 0; i < grid_rubros.Rows.Count; i++)
            {
                string sqlRubros_X_Proveedor = "UPDATE Rubros_X_Proveedor SET " +
                                      " id_rubro = " + grid_rubros.Rows[i].Cells[0].Value.ToString() +
                                      " cuit_proveedor = " + cuit_proveedor;
                _BD_T.Modificar(sqlRubros_X_Proveedor);
            }
            if (_BD_T.FinalTransaccion() == Acceso_Datos_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se modificó el proveedor correctamente");
            }
            else
            {
                MessageBox.Show("No se modificó el proveedor por un error");
            }
        }

    }
}
