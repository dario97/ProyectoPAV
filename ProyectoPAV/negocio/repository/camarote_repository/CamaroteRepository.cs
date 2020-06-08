using ProyectoPAV.entidades;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository.camarote_repository
{
    class CamaroteRepository : IRepository<Camarote, int>
    {
        private static BE_acceso_BD dbAccess = new BE_acceso_BD();
        private const int ELEMENT_WITH_THAT_ID = 0;

        private bool ContainRows(DataTable table)
        {
            if(table.Rows.Count != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Create(Camarote camarote)
        {
            string strSQL = "INSERT INTO CAMAROTES (Cod_navio, Num_cubierta, Num_camarote, Tipo, Ubicacion, Cant_camas) " +
                " VALUES (" +
                "'" + camarote.IdNavio + "'" + "," +
                "'" + camarote.NumCubierta + "'" + "," +
                "'" + camarote.NumCamarote + "'" + "," +
                "'" + camarote.IdTipoCamarote + "'" + "," +
                "'" + camarote.Ubicacion + "'" + "," +
                "'" + camarote.CantCamas + "'" + ")";

            dbAccess.insertar(strSQL);
        }

        public void DeleteById(int id)
        {
            string sql = "DELETE FROM CAMAROTES WHERE id= " + id;
            dbAccess.borrar(sql);
        }

        public List<Camarote> GetAll()
        {
            string sql = "SELECT * FROM CAMAROTES";
            DataTable dataTable = dbAccess.ejecutarConsulta(sql);
            List<Camarote> camarotesList = new List<Camarote>();

            if (ContainRows(dataTable))
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Camarote camarote = Mapping(dataTable.Rows[i]);

                    camarotesList.Add(camarote);
                }
            }

            return camarotesList;
        }
        public Camarote GetById(int id)
        {
            string sql = "SELECT * FROM CAMAROTES WHERE id= " + id;
            DataTable dataTable = dbAccess.ejecutarConsulta(sql);

            if (ContainRows(dataTable))
            {
                return Mapping(dataTable.Rows[ELEMENT_WITH_THAT_ID]);
            }
            else
            {
                return null;
            }        
        }

        public Camarote GetByPrimaryKey(int idNavio, int numCubierta, int numCamarote)
        {
            string sql = @"SELECT * FROM CAMAROTES WHERE Cod_navio = " + idNavio + " AND " + "Num_cubierta = " + numCubierta + " AND " + "Num_camarote = " + numCamarote;
            DataTable table = dbAccess.ejecutarConsulta(sql);

            if (ContainRows(table))
            {
                return Mapping(table.Rows[ELEMENT_WITH_THAT_ID]);
            }
            else
            {
                return null;
            }

        }

        public Camarote Mapping(DataRow row)
        {
            int id = Convert.ToInt32(row["id"].ToString());
            int idNavio = Convert.ToInt32(row["Cod_navio"].ToString());
            int numCubierta = Convert.ToInt32(row["Num_cubierta"].ToString());
            int numCamarote = Convert.ToInt32(row["Num_camarote"].ToString());
            int idTipoCamarote = Convert.ToInt32(row["Tipo"].ToString());
            string ubicacion = row["Ubicacion"].ToString();
            int cantCamas = Convert.ToInt32(row["Cant_camas"].ToString());

            return new Camarote(id, idNavio, numCubierta, numCamarote, idTipoCamarote, ubicacion, cantCamas);
        }

        public void Update(Camarote camarote)
        {
            string strSQL = "UPDATE CAMAROTES " +
                             "SET Cod_navio=" + "'" + camarote.IdNavio + "'" + "," +
                             " Num_cubierta=" + "'" + camarote.NumCubierta + "'" + "," +
                             " Num_camarote=" + "'" + camarote.NumCamarote + "'" + "," +
                             " Tipo=" + "'" + camarote.IdTipoCamarote + "'" + "," +
                             " Ubicacion=" + "'" + camarote.Ubicacion + "'" + "," +
                             " Cant_camas=" + "'" + camarote.CantCamas + "'" +
                             " WHERE Cod_navio=" + camarote.IdNavio + " AND " + "Num_cubierta=" + camarote.NumCubierta + " AND " + " Num_camarote=" + camarote.NumCamarote;

            dbAccess.modificar(strSQL);
        }
    }

}




