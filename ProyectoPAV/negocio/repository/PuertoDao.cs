using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV.negocio.repository
{
    class PuertoDao
    {
        private static BE_acceso_BD accesoBD;

        public PuertoDao()
        {
            accesoBD = new BE_acceso_BD();
        }

        //private Puerto mapping(DataRow row)
        //{
        //    int codPuerto = row["Cod_puerto"];
        //    string nombre = row["Nombre"].ToString();

        //    Puerto puerto = new Puerto(codPuerto, nombre);

        //    return puerto;
        //}


        public Puerto getById(int id)
        {
            string sql = "SELECT * FROM PUERTOS WHERE Cod_puerto=" + id;

            DataTable dataTable = accesoBD.ejecutarConsulta(sql);
            Puerto puerto = null;
            
            if(dataTable.Rows.Count != 0)
            {
                string nombre = dataTable.Rows[0]["Nombre"].ToString();
                puerto = new Puerto(id, nombre);
            }

            return puerto;
        }


        public DataTable consultar_x_nombre(string nombre)
        {

            string sql = @"SELECT * FROM PUERTOS WHERE Nombre like '%" + nombre + "%'";
            return accesoBD.ejecutarConsulta(sql);

        }

        public DataTable consultarTodos()
        {

            string sql = @"SELECT * FROM PUERTOS";
            return accesoBD.ejecutarConsulta(sql);

        }

        private int getLastPuertoInsertId()
        {
            string sql = "SELECT IDENT_CURRENT " + "(" + "'" + "PUERTOS" + "'" + ")" +  "AS id";
            DataTable dataTable = accesoBD.ejecutarConsulta(sql);
            int id = Convert.ToInt32(dataTable.Rows[0]["id"]);

            return id;

        }

        internal bool create(Puerto puerto)
        {
            string strSQL = "INSERT INTO PUERTOS (Nombre)" +
                " VALUES (" +
                "'" + puerto.Nombre + "'" + ")";

            DataTable tabla = accesoBD.ejecutarConsulta(strSQL);
            int id = getLastPuertoInsertId();
            Console.WriteLine(id);

            return true;
        }
        
        internal bool update(Puerto puerto)
        {
            string strSQL = "UPDATE PUERTOS " +
                             "SET Nombre=" + "'" + puerto.Nombre + "'" +
                             " WHERE Cod_puerto=" + puerto.CodigoPuerto;

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }

        internal bool delete(int id)
        {
            string strSQL = "DELETE FROM PUERTOS " +
                                " WHERE Cod_puerto =" + id;

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }




    }
}
