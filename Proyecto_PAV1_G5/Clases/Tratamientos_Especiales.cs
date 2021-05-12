using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Proyecto_PAV1_G5.BackEnd;


namespace Proyecto_PAV1_G5.Clases
{
    class Tratamientos_Especiales
    {
        public enum Resultado { correcto, error }

        public Resultado Validar(Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox01)item).Text == "")
                    {
                        MessageBox.Show(((TextBox01)item).Pp_MensajeError);
                        ((TextBox01)item).Focus();
                        return Resultado.error;
                    }

                }
                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item).SelectedIndex == -1)
                    {
                        MessageBox.Show(((ComboBox01)item).Pp_MensajeError);
                        ((ComboBox01)item).Focus();
                        return Resultado.error;
                    }
                }
            }
            return Resultado.correcto;
        }

        public string ConstructorInsertar(string NombreTabla, Control.ControlCollection controles)
        {
            string sql = "INSERT INTO " + NombreTabla + " (";
            string columna = "";
            string tipoDatoColumna = "";
            string valorColumna = "";
            string paqueteColumnas = "";
            string paqueteValores = "";

            DataTable Estructura = new DataTable();
            Estructura = BuscarEstructuraTabla(NombreTabla);


            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                columna = Estructura.Columns[i].Caption;
                //Caption devuelve el nombre de la columna de Estructura en la posicion Estructura.Columns[i]
                tipoDatoColumna = Estructura.Columns[i].DataType.Name;
                valorColumna = BuscarColumnaEnControles(columna, controles);
                if (valorColumna != string.Empty)
                //Tambien se puede comparar contra ""
                {
                    valorColumna = FormatearDato(valorColumna, tipoDatoColumna);
                    if (paqueteColumnas == "")
                    {
                        paqueteColumnas = columna;
                        paqueteValores = valorColumna;
                    }
                    else
                    {
                        paqueteColumnas += ", " + columna;
                        paqueteValores += ", " + valorColumna;
                    }
                }

            }
            sql += paqueteColumnas + ") VALUES (" + paqueteValores + ")";
            return sql;
        }


        public string ConstructorModificar_Con_PK(string NombreTabla, string[] ValorPK, Control.ControlCollection controles)
        {
            string sql = "UPDATE " + NombreTabla + " SET ";
            string columna = "";
            string tipoDatoColumna = "";
            string valorColumna = "";
            string minisql = "";

            DataTable Estructura = new DataTable();
            Estructura = BuscarEstructuraTabla(NombreTabla);

            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                columna = Estructura.Columns[i].Caption;
                //Caption devuelve el nombre de la columna de Estructura en la posicion Estructura.Columns[i]
                tipoDatoColumna = Estructura.Columns[i].DataType.Name;
                valorColumna = BuscarColumnaEnControles(columna, controles);
                if (valorColumna != string.Empty)
                {
                    valorColumna = FormatearDato(valorColumna, tipoDatoColumna);
                    if (i==0)
                    {
                        sql += columna + " = " + valorColumna;
                    }
                    else
                    {
                        sql += ", " + columna + " = " + valorColumna;
                    }
                }

            }
            DataTable tabla = BuscarPkTabla(NombreTabla);
            if (tabla.Rows.Count > 1)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        minisql += tabla.Rows[0][0].ToString() + " = " + ValorPK[0];
                    }
                    else
                    {
                        minisql += " AND " + tabla.Rows[i][0].ToString() + " = " + ValorPK[i];
                    }
                }
            }
            else
            {
                string NombrePK = tabla.Rows[0][0].ToString();
                minisql += NombrePK + " = " + ValorPK[0];
            }
            sql += " WHERE " + minisql;
            return sql;
        }

        public string ConstructorModificar_Sin_PK(string NombreTabla, string[] ValorPK, Control.ControlCollection controles)
        {
            string sql = "UPDATE " + NombreTabla + " SET ";
            string columna = "";
            string tipoDatoColumna = "";
            string valorColumna = "";
            string minisql = "";

            DataTable Estructura = new DataTable();
            Estructura = BuscarEstructuraTabla(NombreTabla);
            int Cantidad_PKs = ValorPK.Length;

            for (int i = Cantidad_PKs; i < Estructura.Columns.Count; i++)
            {
                columna = Estructura.Columns[i].Caption;
                //Caption devuelve el nombre de la columna de Estructura en la posicion Estructura.Columns[i]
                tipoDatoColumna = Estructura.Columns[i].DataType.Name;
                valorColumna = BuscarColumnaEnControles(columna, controles);
                if (valorColumna != string.Empty)
                {
                    valorColumna = FormatearDato(valorColumna, tipoDatoColumna);
                    if (i == Cantidad_PKs)
                    {
                        sql += columna + " = " + valorColumna;
                    }
                    else
                    {
                        sql += ", " + columna + " = " + valorColumna;
                    }
                }

            }
            DataTable tabla = BuscarPkTabla(NombreTabla);
            if (tabla.Rows.Count > 1)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        minisql += tabla.Rows[0][0].ToString() + " = " + ValorPK[0];
                    }
                    else
                    {
                        minisql += " AND " + tabla.Rows[i][0].ToString() + " = " + ValorPK[i];
                    }
                }
            }
            else
            {
                string NombrePK = tabla.Rows[0][0].ToString();
                minisql += NombrePK + " = " + ValorPK[0];
            }
            sql += " WHERE " + minisql;
            return sql;
        }

        public string ConstructorEliminar (string NombreTabla, string[] ValorPK, Control.ControlCollection controles)
        {
            string minisql = "";
            DataTable tabla = BuscarPkTabla(NombreTabla);

            if (tabla.Rows.Count > 1)
            {
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        minisql += tabla.Rows[0][0].ToString() + " = " + ValorPK[0];
                    }
                    else
                    {
                        minisql += " AND " + tabla.Rows[i][0].ToString() + " = " + ValorPK[i];
                    }
                }
            }
            else
            {
                string NombrePK = tabla.Rows[0][0].ToString();
                minisql += NombrePK + " = " + ValorPK[0];
            }
            string sql = "DELETE FROM " + NombreTabla + " WHERE " + minisql ;
            return sql;
        }

        private DataTable BuscarPkTabla(string NombreTabla)
        {
            Acceso_Datos _BD = new Acceso_Datos();
            string sql = @"select Col.COLUMN_NAME from INFORMATION_SCHEMA.TABLE_CONSTRAINTS Tab "
                        + "join INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE Col "
                        + "on Col.Constraint_Name = Tab.Constraint_Name "
                        + "and Col.Table_Name = Tab.Table_Name "
                        + "where Constraint_Type = 'PRIMARY KEY' and Col.CONSTRAINT_NAME = 'PK_" + NombreTabla + "'";
            return _BD.Ejecutar_Select(sql);
        }

        private DataTable BuscarEstructuraTabla(string NombreTabla)
        {
            Acceso_Datos _BD = new Acceso_Datos();
            return _BD.Ejecutar_Select("SELECT TOP 1 * FROM " + NombreTabla);
        }


        private string BuscarColumnaEnControles(string campo, Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox01)item).Pp_campo == campo)
                    {
                        return ((TextBox01)item).Text;
                    }

                }
                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item).Pp_NombreCampo == campo)
                    {
                        return ((ComboBox01)item).SelectedValue.ToString();
                    }
                }
            }
            return "";
        }
        private string FormatearDato(string valorColumna, string tipoDatoColumna)
        {
            switch (tipoDatoColumna)
            {
                case "String":
                case "Date":
                case "DateTime":
                    return "'" + valorColumna + "'";
                //al valor columna pasado por parámetro le agrego comillas simples y retorno eso
                case "Int16":
                case "Int32":
                case "Int64":
                case "Decimal":
                case "Float":
                case "Single":
                    return valorColumna;
                default:
                    return valorColumna;
            }
        }
        public object FormatearIntString(string dato)
        {
            try
            {
                return int.Parse(dato);
            }
            catch (Exception)
            {
                try
                {
                    return float.Parse(dato);
                }
                catch (Exception)
                {
                    return $"'{dato}'";
                    throw;
                }
                throw;
            }
        }
    }
}
