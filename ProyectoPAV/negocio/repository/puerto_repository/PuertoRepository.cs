using ProyectoPAV.entidades;
using ProyectoPAV.negocio.servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository.puerto_repository
{
    class PuertoRepository : IRepository<Puerto, int>
    {

        private static BE_acceso_BD dbAccess = new BE_acceso_BD();
        private const int ELEMENT_WITH_THAT_ID = 0;
        private bool ContainRows(DataTable table)
        {
            if(table.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Create(Puerto puerto)
        {
            string strSQL = "INSERT INTO PUERTOS (Nombre)" +
                " VALUES (" +
                "'" + puerto.Nombre + "'" + ")";

            dbAccess.insertar(strSQL);
        }

        public void DeleteById(int id)
        {
            string strSQL = "DELETE FROM PUERTOS " +
                                " WHERE Cod_puerto =" + id;

            dbAccess.borrar(strSQL);
        }

        public List<Puerto> GetAll()
        {
            string sql = @"SELECT * FROM PUERTOS";
            DataTable dataTable = dbAccess.ejecutarConsulta(sql);
            List<Puerto> puertos = new List<Puerto>();
            if (ContainRows(dataTable))
            {
                for(int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Puerto puerto = Mapping(dataTable.Rows[i]);
                    puertos.Add(puerto);
                }
                
            }
            return puertos;
            
        }

        public Puerto GetById(int id)
        {
            string sql = "SELECT * FROM PUERTOS WHERE Cod_puerto=" + id;

            DataTable dataTable = dbAccess.ejecutarConsulta(sql);

            if (dataTable.Rows.Count != 0)
            {
                return Mapping(dataTable.Rows[ELEMENT_WITH_THAT_ID]);
            }
            else
            {
                return null;
            }
        }

        public List<Puerto> GetByName(string name)
        {
            string sql = @"SELECT * FROM PUERTOS WHERE Nombre like '%" + name + "%'";
            DataTable table = dbAccess.ejecutarConsulta(sql);
            List<Puerto> puertos = new List<Puerto>();

            if (ContainRows(table))
            {
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    Puerto puerto = Mapping(table.Rows[i]);
                    puertos.Add(puerto);
                }
            }

            return puertos;
        }
         

        public Puerto Mapping(DataRow row)
        {
            int codPuerto = Convert.ToInt32(row["Cod_puerto"]);
            string nombre = row["Nombre"].ToString();

            Puerto puerto = new Puerto(codPuerto, nombre);

            return puerto;
        }

        public void Update(Puerto puerto)
        {
            string strSQL = "UPDATE PUERTOS " +
                             "SET Nombre=" + "'" + puerto.Nombre + "'" +
                             " WHERE Cod_puerto=" + puerto.CodigoPuerto;

            dbAccess.ejecutarConsulta(strSQL);
        }
    }
}
