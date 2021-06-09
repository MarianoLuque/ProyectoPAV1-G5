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
    class NE_Rubros
    {
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        public void Modificar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Modificar(tratamiento.ConstructorModificar_Con_PK("Rubros", ValorPk, controles));
        }

        public void Insertar(Control.ControlCollection controles)
        {
            _BD.Insertar(tratamiento.ConstructorInsertar("Rubros", controles));
        }

        public void Eliminar(string[] ValorPk, Control.ControlCollection controles)
        {
            _BD.Borrar(tratamiento.ConstructorEliminar("Rubros", ValorPk, controles));
        }

        Acceso_Datos _BD = new Acceso_Datos();

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

        public DataTable RecuperarRubro(string id_rubro)
        {
            string sql = "SELECT * FROM Rubros WHERE id_rubro = " + id_rubro;
            return (_BD.Ejecutar_Select(sql));
        }

        public DataTable ReporteRubros(bool banderaRB1, bool banderaRB2, bool IDdesde, bool IDhasta, bool patron, bool ambosID, string patron_nombre, string id_desde, string id_hasta)
        {
            string sql = "SELECT * FROM Rubros WHERE 1 = 1 ";

            if (patron)
            {
                if (banderaRB1)
                {
                    sql += " AND nombre_rubro like '" + patron_nombre + "%' ";
                }
                if (banderaRB2)
                {
                    sql += " AND nombre_rubro like '%" + patron_nombre + "%' ";
                }
            }

            if (IDdesde)
            {
                sql += (" AND id_rubro > " + id_desde);
            }
            if (IDhasta)
            {
                sql += (" AND id_rubro < " + id_hasta);
            }
            if (ambosID)
            {
                sql += (" AND id_rubro between " + id_desde + " AND " + id_hasta);
            }

            return (_BD.Ejecutar_Select(sql));
        }
    }
}
