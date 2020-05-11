using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository
{
    public class TipoCamaroteDao
    {
        private static BE_acceso_BD accesoBD; 
        
        public TipoCamaroteDao()
        {
            accesoBD = new BE_acceso_BD();
        }

        public TipoCamarote getById(int id)
        {
            string sql = "SELECT* FROM TIPO_CAMAROTE WHERE Tipo= " + id;
            DataTable data = accesoBD.ejecutarConsulta(sql);

            int idTipo = Convert.ToInt32(data.Rows[0]["Tipo"].ToString());
            string nombre = data.Rows[0]["Nombre"].ToString();

            return new TipoCamarote(idTipo, nombre);
        }

        public List<TipoCamarote> getAll()
        {
            string sql = "SELECT * FROM TIPO_CAMAROTE";
            DataTable data = accesoBD.ejecutarConsulta(sql);
            List<TipoCamarote> tiposList = new List<TipoCamarote>();

            for (int i=0; i < data.Rows.Count; i++)
            {
                int idTipo = Convert.ToInt32(data.Rows[i]["Tipo"].ToString());
                string nombre = data.Rows[i]["Nombre"].ToString();

                TipoCamarote tipo = new TipoCamarote(idTipo, nombre);

                tiposList.Add(tipo);
            }

            return tiposList;
        }

        internal bool delete(int id)
        {
            string strSQL = "DELETE FROM TIPO_CAMAROTE " +
                                " WHERE Tipo = " + id;

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }




        public DataTable consultar_x_nombre(string nombre)
        {
            string sql = "SELECT * FROM TIPO_CAMAROTE WHERE Nombre= " + "'" + nombre + "'";
            return accesoBD.ejecutarConsulta(sql);
        }

        public void create(TipoCamarote tipoCamarote)
        {
            string sql = "INSERT INTO TIPO_CAMAROTE (Nombre)" +
                "VALUES (" +
                "'" + tipoCamarote.Nombre + "'" + ")";

            accesoBD.ejecutarConsulta(sql);
        }
    }

}
