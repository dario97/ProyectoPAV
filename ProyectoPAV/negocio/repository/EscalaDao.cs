using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository
{
    class EscalaDao
    {
       private BE_acceso_BD accesoBD;

        public EscalaDao()
        {
            this.accesoBD = new BE_acceso_BD();
        }

        private Escala mapping(DataRow row)
        {
            int id = Convert.ToInt32(row["id"].ToString());
            int idItinerario = Convert.ToInt32(row["Cod_itinerario"].ToString());
            int numEscala = Convert.ToInt32(row["Num_escala"].ToString());
            int idPuerto = Convert.ToInt32(row["Cod_puerto"].ToString());

            Escala escala = new Escala(id,idItinerario, numEscala, idPuerto);

            return escala;
        }

        public Escala getById(int id)
        {
            string sql = "SELECT * FROM PUERTO_ITINERARIO WHERE id= " + id ;
            DataTable dataTable = accesoBD.ejecutarConsulta(sql);
           
            return mapping(dataTable.Rows[0]);
        }

        public List<Escala> getAllEscalasDeUnItinerario(int idItinerario)
        {
            string sql = "SELECT * FROM PUERTO_ITINERARIO WHERE Cod_itinerario=" + idItinerario + " ORDER BY " + " Num_escala ASC ";
            DataTable dataTable = accesoBD.ejecutarConsulta(sql);
            List<Escala> escalasList = new List<Escala>();

            if (dataTable.Rows.Count != 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    Escala escala = mapping(row);
                    escalasList.Add(escala);
                }
            }
            return escalasList;
        }

        public List<Escala> getAll()
        {
            string sql = "SELECT * FROM PUERTO_ITINERARIO";
            DataTable dataTable = accesoBD.ejecutarConsulta(sql);
            List<Escala> escalasList = new List<Escala>();

            if (dataTable.Rows.Count != 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    Escala escala = mapping(row);
                    escalasList.Add(escala);
                }
            }
            return escalasList;
        }
        internal bool create(Escala escala)
        {
            string strSQL = "INSERT INTO PUERTO_ITINERARIO (Cod_itinerario, Num_escala, Cod_puerto) " +
                " VALUES (" +
                "'" + escala.IdItinerario + "'" + "," +
                "'" + escala.NumEscala + "'" + "," + 
                "'" + escala.IdPuerto + "'" + ")";

            BE_acceso_BD.estado_BE estado = accesoBD.insertar(strSQL);

            return verifyState(estado);
        }
        internal bool update(Escala escala)
        {
            string strSQL = "UPDATE PUERTO_ITINERARIO " +
                             " SET Cod_itinerario=" + "'" + escala.IdItinerario + "'" + "," +
                             " Num_escala=" + "'" + escala.NumEscala + "'" + "," +
                             " Cod_puerto=" + "'" + escala.IdPuerto + "'" +
                             " WHERE Cod_itinerario=" + escala.IdItinerario + " AND " + " Num_escala= " + escala.NumEscala;

            BE_acceso_BD.estado_BE estado = accesoBD.modificar(strSQL);

            return verifyState(estado);


        }
        internal bool delete(Escala escala)
        {
            return this.deleteById(escala.Id);
        }
        internal bool deleteById(int id)
        {
            string sql = "DELETE FROM PUERTO_ITINERARIO WHERE id = " + id;
            BE_acceso_BD.estado_BE estado = accesoBD.borrar(sql);

            return verifyState(estado);
        }

        private bool verifyState(BE_acceso_BD.estado_BE estado)
        {
            if (estado == BE_acceso_BD.estado_BE.correcto)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}


   










