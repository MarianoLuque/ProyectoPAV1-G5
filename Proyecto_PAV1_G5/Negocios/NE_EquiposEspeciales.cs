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
        public string Codigo_Equipo { get; set; }
        public string Cantidad { get; set; }
        public string Cuit_Cliente { get; set; }
        public string Nombre_Equipo { get; set; }
        public string Precio_Mayorista { get; set; }
        public string Precio_Minorista { get; set; }
        public string Descripcion { get; set; }
        Acceso_Datos _BD = new Acceso_Datos();
        Acceso_Datos_T _BD_T = new Acceso_Datos_T();
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        public Estructura_ComboBox DatosComboArticulo()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "codigo_articulo";
            edc.Display = "nombre_articulo";
            edc.Sql = "SELECT * FROM Articulos";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;

        }

        public Estructura_ComboBox DatosComboCliente()
        {
            Estructura_ComboBox edc = new Estructura_ComboBox();

            edc.Value = "cuit_clientes";
            edc.Display = "razon_social";
            edc.Sql = "SELECT * FROM Clientes";
            edc.Tabla = _BD.Ejecutar_Select(edc.Sql);

            return edc;

        }

        // FUNCIONES CONSULTA
        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT * "
                        + " FROM Equipos_Especiales "; 
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

        //EQUIPOS SIMPLES
        // RECUPERACION DE DATOS SI NO SE SELECCIONO PATRON
        public DataTable RecuperarTodos_Simple()
        {
            string sql = @"SELECT * "
                        + " FROM Equipos "; ;
            return _BD.Ejecutar_Select(sql);
        }

        // RECUPERACION DE DATOS SI SE SELECCIONARON AMBOS PATRONES
        public DataTable Recuperar_Mixto_Simple(string codigo, string nombre_equipo)
        {
            string sql = @"SELECT * FROM Equipos "
                        + "WHERE codigo_equipo like '%" + codigo.Trim() + "%' AND "
                        + "nombre_equipo like '%" + nombre_equipo.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        // RECUPERACION DE DATOS SI SE SELECCIONO UNICAMENTE EL CODIGO DEL EQUIPO
        public DataTable Recuperar_x_Codigo_Equipo_Simple(string codigo)
        {
            string sql = @"SELECT * FROM Equipos "
                        + "WHERE codigo_equipo like '%" + codigo.Trim() + "%'";
            return _BD.Ejecutar_Select(sql);
        }

        // RECUPERACION DE DATOS SI SELECCIONO UNICAMENTE EL NOMBRE DEL EQUIPO
        public DataTable Recuperar_x_Nombre_Simple(string nombre)
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

        //PARTE DE TRANSACCIONES

        public void InsertarArticulos_X_Equipo(Grid01 grid_articulos)
        {
            string SqlCodigo = "SELECT Max(codigo_equipo) FROM Equipos";
            DataTable tabla = _BD_T.EjecutarSelect(SqlCodigo);

            string SqlInsertarArt = @"INSERT INTO Articulos_X_Equipo (codigo_equipo, codigo_articulo, cantidad_articulos) VALUES ("
                                    + tabla.Rows[0][0].ToString();
            //CUANDO TIENE .Rows[0][0] no hace falta el .Value pero si tenes .Rows[i].Cells[0] si hace falta el .Value

            for (int i = 0; i < grid_articulos.Rows.Count; i++)
            {
                string miniSql = "";

                miniSql = ", " + grid_articulos.Rows[i].Cells[0].Value.ToString() + ", "
                         + grid_articulos.Rows[i].Cells[4].Value.ToString();

                _BD_T.Insertar(SqlInsertarArt + miniSql + ")");
            }
        }

        public void InsertarArticulos_X_Equipo_Especial(Grid01 grid_articulos)
        {
            string SqlInsertarArt = @"INSERT INTO Articulos_X_Equipo_Especial (codigo_equipo_especial, cuit_cliente, codigo_articulo, cantidad_articulos) VALUES ("
                                    + Codigo_Equipo + ", " + Cuit_Cliente;
            for (int i = 0; i < grid_articulos.Rows.Count; i++)
            {
                string miniSql = "";

                miniSql = ", " + grid_articulos.Rows[i].Cells[0].Value.ToString() + ", "
                         + grid_articulos.Rows[i].Cells[4].Value.ToString();

                _BD_T.Insertar(SqlInsertarArt + miniSql + ")");
            }
        }

        public void InsertarEquipoSimple (Grid01 grid_articulos)
        {
            string SqlInsertar = @"INSERT INTO Equipos ( nombre_equipo, precio_mayorista, precio_minorista) VALUES ("
                + " '" + Nombre_Equipo + "', " + Precio_Mayorista + ", " + Precio_Minorista + ")";

            _BD_T.InicioTransaccion();
            _BD_T.Insertar(SqlInsertar);
            InsertarArticulos_X_Equipo(grid_articulos);
            if (_BD_T.FinalTransaccion() == Acceso_Datos_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se grabó correctamente todo");
            }
            else
            {
                MessageBox.Show("No se grabó nada por un error");
            }
        }

        public void InsertarEquipoEspecial(Grid01 grid_articulos)
        {
            string SqlInsertar = @"INSERT INTO Equipos_Especiales (codigo_equipo_especial, cuit_cliente, descripcion, nombre_equipo_especial, precio) VALUES ("
                + Codigo_Equipo + ", " + Cuit_Cliente + ", '" + Descripcion + "' , '" + Nombre_Equipo + "', " + Precio_Mayorista + ")";

            _BD_T.InicioTransaccion();
            _BD_T.Insertar(SqlInsertar);
            InsertarArticulos_X_Equipo_Especial(grid_articulos);
            if (_BD_T.FinalTransaccion() == Acceso_Datos_T.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se grabó correctamente todo");
            }
            else
            {
                MessageBox.Show("No se grabó nada por un error");
            }
        }


        public DataTable RecuperarArticulo(string codigo)
        {
            string sql = "SELECT * FROM Articulos WHERE codigo_articulo = " + codigo;
            return (_BD.Ejecutar_Select(sql));
        }



    }
}
