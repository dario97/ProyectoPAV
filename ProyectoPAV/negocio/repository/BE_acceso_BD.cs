using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository
{
    class BE_acceso_BD
    {
        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        string cadenaConexion = "Provider=SQLNCLI10;Data Source=DESKTOP-OKDL643\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=ProyectoPAV1";

        private void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
        }
        private void desconectar()
        {

            conexion.Close();

        }

        public DataTable ejecutarConsulta(string consultaSQL)
        {
            conectar();
            DataTable tabla = new DataTable();
            cmd.CommandText = consultaSQL;
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;
        }
    }
}
