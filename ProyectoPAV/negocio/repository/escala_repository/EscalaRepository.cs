using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV.negocio.repository.escala_repository
{
    class EscalaRepository : IRepository<Escala, int>
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
        
        public void Create(Escala escala)
        {
            string strSQL = "INSERT INTO PUERTO_ITINERARIO (Cod_itinerario, Num_escala, Cod_puerto) " +
                " VALUES (" +
                "'" + escala.IdItinerario + "'" + "," +
                "'" + escala.NumEscala + "'" + "," +
                "'" + escala.IdPuerto + "'" + ")";

            BE_acceso_BD.estado_BE estado = dbAccess.insertar(strSQL);

            //return verifyState(estado);
        }

        public void DeleteById(int id)
        {
            string sql = "DELETE FROM PUERTO_ITINERARIO WHERE id = " + id;
            BE_acceso_BD.estado_BE estado = dbAccess.borrar(sql);

            //return verifyState(estado);
        }

        public List<Escala> GetAll()
        {
            string sql = "SELECT * FROM PUERTO_ITINERARIO";
            DataTable dataTable = dbAccess.ejecutarConsulta(sql);
            List<Escala> escalasList = new List<Escala>();

            if (ContainRows(dataTable))
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    Escala escala = Mapping(row);
                    escalasList.Add(escala);
                }
            }
            return escalasList;
        }

        public Escala GetById(int id)
        {
            string sql = "SELECT * FROM PUERTO_ITINERARIO WHERE id= " + id;
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

        public Escala Mapping(DataRow row)
        {
            int id = Convert.ToInt32(row["id"].ToString());
            int idItinerario = Convert.ToInt32(row["Cod_itinerario"].ToString());
            int numEscala = Convert.ToInt32(row["Num_escala"].ToString());
            int idPuerto = Convert.ToInt32(row["Cod_puerto"].ToString());

            Escala escala = new Escala(id, idItinerario, numEscala, idPuerto);

            return escala;
        }

        public List<Escala> GetAllEscalasFromItinerario(int idItinerario)
        {
            string sql = "SELECT * FROM PUERTO_ITINERARIO WHERE Cod_itinerario=" + idItinerario + " ORDER BY " + " Num_escala ASC ";
            DataTable dataTable = dbAccess.ejecutarConsulta(sql);
            List<Escala> escalasList = new List<Escala>();

            if (ContainRows(dataTable))
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    Escala escala = Mapping(row);
                    escalasList.Add(escala);
                }
            }
            return escalasList;
        }
        public void Update(Escala escala)
        {
            string strSQL = "UPDATE PUERTO_ITINERARIO " +
                             " SET Cod_itinerario=" + "'" + escala.IdItinerario + "'" + "," +
                             " Num_escala=" + "'" + escala.NumEscala + "'" + "," +
                             " Cod_puerto=" + "'" + escala.IdPuerto + "'" +
                             " WHERE Cod_itinerario=" + escala.IdItinerario + " AND " + " Num_escala= " + escala.NumEscala;

            BE_acceso_BD.estado_BE estado = dbAccess.modificar(strSQL);

            //return verifyState(estado);
        }
    }
}
