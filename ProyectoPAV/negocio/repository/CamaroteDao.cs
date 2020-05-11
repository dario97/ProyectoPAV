using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository
{
    class CamaroteDao
    {
        private static BE_acceso_BD accesoBD;

        public CamaroteDao()
        {

            accesoBD = new BE_acceso_BD();

        }

        public Camarote consultarCamarote(int codNavio, int numCubierta, int numCamarote)
        {

            string sql = @"SELECT * FROM CAMAROTES WHERE Cod_navio = " + codNavio + " AND " + "Num_cubierta = " + numCubierta + " AND " + "Num_camarote = " + numCamarote;
            DataTable dataTable = accesoBD.ejecutarConsulta(sql);
            Camarote camarote = null;

            if(dataTable.Rows.Count != 0)
            {
                int id = Convert.ToInt32(dataTable.Rows[0]["id"].ToString());
                int idTipo = Convert.ToInt32(dataTable.Rows[0]["Tipo"].ToString());
                string ubicacion = dataTable.Rows[0]["Ubicacion"].ToString();
                int cantCamas = Convert.ToInt32(dataTable.Rows[0]["Cant_camas"].ToString());

                camarote = new Camarote(id, codNavio, numCubierta, numCamarote, idTipo, ubicacion, cantCamas);

                return camarote;

            }

            return camarote;
            
            

            


        }

        public Camarote getById(int idCamarote)
        {
            string sql = "SELECT * FROM CAMAROTES WHERE id= " + idCamarote;
            DataTable dataTable = accesoBD.ejecutarConsulta(sql);

            int id = Convert.ToInt32(dataTable.Rows[0]["id"].ToString());
            int idNavio = Convert.ToInt32(dataTable.Rows[0]["Cod_navio"].ToString());
            int numCubierta = Convert.ToInt32(dataTable.Rows[0]["Num_cubierta"].ToString());
            int numCamarote = Convert.ToInt32(dataTable.Rows[0]["Num_camarote"].ToString());
            int idTipo = Convert.ToInt32(dataTable.Rows[0]["Tipo"].ToString());
            string ubicacion = dataTable.Rows[0]["Ubicacion"].ToString();
            int cantCamas = Convert.ToInt32(dataTable.Rows[0]["Cant_camas"].ToString());

            Camarote camarote = new Camarote(id, idNavio, numCubierta, numCamarote, idTipo, ubicacion, cantCamas);

            return camarote;


        }

        public List<Camarote> getAll()
        {
            string sql = "SELECT * FROM CAMAROTES";
            DataTable dataTable = accesoBD.ejecutarConsulta(sql);
            List<Camarote> camarotesList = new List<Camarote>();
            
            if(dataTable.Rows.Count != 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(dataTable.Rows[i]["id"].ToString());
                    int idNavio = Convert.ToInt32(dataTable.Rows[i]["Cod_navio"].ToString());
                    int numCubierta = Convert.ToInt32(dataTable.Rows[i]["Num_cubierta"].ToString());
                    int numCamarote = Convert.ToInt32(dataTable.Rows[i]["Num_camarote"].ToString());
                    int idTipo = Convert.ToInt32(dataTable.Rows[i]["Tipo"].ToString());
                    string ubicacion = dataTable.Rows[i]["Ubicacion"].ToString();
                    int cantCamas = Convert.ToInt32(dataTable.Rows[i]["Cant_camas"].ToString());

                    Camarote camarote = new Camarote(id, idNavio, numCubierta, numCamarote, idTipo, ubicacion, cantCamas);

                    camarotesList.Add(camarote);
                }
            }
            

            return camarotesList;
        }

        public DataTable consultarTodos()
        {

            string sql = @"SELECT * FROM CAMAROTES";
            return accesoBD.ejecutarConsulta(sql);

        }



        internal bool create(Camarote camarote)
        {
            string strSQL = "INSERT INTO CAMAROTES (Cod_navio, Num_cubierta, Num_camarote, Tipo, Ubicacion, Cant_camas) " +
                " VALUES (" +
                "'" + camarote.IdNavio + "'" + "," +
                "'" + camarote.NumCubierta + "'" + "," +
                "'" + camarote.NumCamarote + "'" + "," +
                "'" + camarote.IdTipoCamarote + "'" + "," +
                "'" + camarote.Ubicacion+ "'" + "," +
                "'" + camarote.CantCamas + "'" + ")";

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }

        internal bool update(Camarote camarote)
        {
            string strSQL = "UPDATE CAMAROTES " +
                             "SET Cod_navio=" + "'" + camarote.IdNavio + "'" + "," +
                             " Num_cubierta=" + "'" + camarote.NumCubierta + "'" + "," +
                             " Num_camarote=" + "'" + camarote.NumCamarote + "'" + "," +
                             " Tipo=" + "'" + camarote.IdTipoCamarote + "'" + "," +
                             " Ubicacion=" + "'" + camarote.Ubicacion + "'" + "," +
                             " Cant_camas=" + "'" + camarote.CantCamas + "'" + 
                             " WHERE Cod_navio=" + camarote.IdNavio + " AND " + "Num_cubierta=" + camarote.NumCubierta + " AND " + " Num_camarote=" + camarote.NumCamarote;

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }

        internal bool delete(Camarote camarote)
        {
            string strSQL = "DELETE FROM NAVIOS " +
                                " WHERE Cod_navio =" + camarote.IdNavio + " AND " + "Num_cubierta=" + camarote.NumCubierta + " AND " + "Num_camarote="+ camarote.NumCamarote;



            accesoBD.ejecutarConsulta(strSQL);
            return true;


        }
    }
}
