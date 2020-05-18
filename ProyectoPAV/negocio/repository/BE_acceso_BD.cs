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
        public enum estado_BE { correcto, error}

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

        public estado_BE insertar(string sql)
        {
            this.conectar();
            this.cmd.CommandText = sql;
            this.cmd.ExecuteNonQuery();
            this.desconectar();
            return estado_BE.correcto;
        }
        public estado_BE modificar(string sql)
        {
            this.conectar();
            this.cmd.CommandText = sql;
            this.cmd.ExecuteNonQuery();
            this.desconectar();
            return estado_BE.correcto;
        }
        public estado_BE borrar(string sql)
        {
            this.conectar();
            this.cmd.CommandText = sql;
            this.cmd.ExecuteNonQuery();
            this.desconectar();
            return estado_BE.correcto;
        }


    }
}
