using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV.negocio.repository
{
    class BE_acceso_BD
    {
        public enum tipo_conexion { simple, transaccion }
        public enum estado_BE { correcto, error}

        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbTransaction transaccion;

        string cadenaConexion = "Provider=SQLNCLI10;Data Source=DESKTOP-OKDL643\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=ProyectoPAV1";

        estado_BE control_transaccion = estado_BE.correcto;
        tipo_conexion analisis_tipo_conexion = tipo_conexion.simple;



        public void iniciar_transaccion()
        {
            analisis_tipo_conexion = tipo_conexion.transaccion;
            control_transaccion = estado_BE.correcto;
        }

        public void cerrar_transaccion()
        {
            if (analisis_tipo_conexion == tipo_conexion.simple)
            {
                MessageBox.Show("Está intentado cerrar una transacción que no abrio"
                    , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (control_transaccion == estado_BE.correcto)
            {
                transaccion.Commit();
            }
            else
            {
                transaccion.Rollback();
            }
            analisis_tipo_conexion = tipo_conexion.simple;
            desconectar();
        }



        private void conectar()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                if (analisis_tipo_conexion == tipo_conexion.transaccion)
                {
                    transaccion = conexion.BeginTransaction(IsolationLevel.ReadCommitted);
                    cmd.Transaction = transaccion;
                }
            };
        }
        private void desconectar()
        {

            if (analisis_tipo_conexion == tipo_conexion.simple)
            {
                conexion.Close();
            }

        }
        public DataTable ejecutarConsulta(string consultaSQL)
        {
            conectar();
            DataTable tabla = new DataTable();
            cmd.CommandText = consultaSQL;
            try
            {
                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                control_transaccion = estado_BE.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                    + "En el comando:" + "\n"
                    + consultaSQL + "\n"
                    + "El mensaje es:" + "\n"
                    + e.Message);

                throw e;
            }
            desconectar();
            return tabla;
        }

        private estado_BE ejecutar(string sql)
        {
            this.conectar();
            this.cmd.CommandText = sql;
            try
            {
                this.cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                control_transaccion = estado_BE.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                    + "En el comando:" + "\n"
                    + sql + "\n"
                    + "El mensaje es:" + "\n"
                    + e.Message);
            }
            desconectar();
            return control_transaccion;
        }

        public estado_BE insertar(string sql)
        {
            return ejecutar(sql);
        }
        public estado_BE modificar(string sql)
        {
            return ejecutar(sql);
        }
        public estado_BE borrar(string sql)
        {
            return ejecutar(sql);
        }


    }
}
