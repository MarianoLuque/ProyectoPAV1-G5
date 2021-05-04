using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_PAV1_G5.BackEnd
{
    class Acceso_Datos
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        private void conectar()
        {
            conexion.ConnectionString = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K6G05_2021;Persist Security Info=True;User ID=BD3K6G05_2021;Password=BDG05_9852";
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
        }
        private void desconectar()
        {
            conexion.Close();
        }
        public DataTable Ejecutar_Select(string sql)
        {
            conectar();
            cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;
        }
        public void Insertar(string SqlInsertar)
        {
            InsModBorr(SqlInsertar);
        }
        public void Modificar(string SqlModificar)
        {
            InsModBorr(SqlModificar);
        }
        public void Borrar(string SqlBorrar)
        {
            InsModBorr(SqlBorrar);
        }
        private void InsModBorr(string sql)
        {
            conectar();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            desconectar();
        }
    }
}
