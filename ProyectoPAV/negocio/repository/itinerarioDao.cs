using ProyectoPAV.entidades;
using ProyectoPAV.negocio.servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository
{
     public class ItinerarioDao
    {
        private static BE_acceso_BD accesoBD;

        public ItinerarioDao()
        {

            accesoBD = new BE_acceso_BD();

        }

        private Itinerario mapping(DataRow row)
        {
            int id = Convert.ToInt32(row["Cod_itinerario"].ToString());
            string descripcion = row["Descripcion"].ToString();
            string categoria = row["Categoria"].ToString();

            Itinerario itinerario = new Itinerario(id, descripcion, categoria);
            return itinerario;
        }

        public bool cargarItinerario(Itinerario itinerario)
        {
            
            accesoBD.iniciar_transaccion();
            this.create(itinerario);
            int id = getLastItinerarioInsertId();

            List<Escala> escalas = new List<Escala>(itinerario.Escalas);
            EscalaService escalaService = new EscalaService();

            for (int i = 0; i<escalas.Count; i++)
            {
                escalas[i].IdItinerario = id;
                escalaService.create(escalas[i]);
            }
            accesoBD.cerrar_transaccion();
            
                

                
            Console.WriteLine(id);
            return true;
        }


        public Itinerario getById(int idItinerario)
        {
            string sql = "SELECT * FROM ITINERARIOS WHERE Cod_itinerario= " + idItinerario;
            DataTable dataTable = accesoBD.ejecutarConsulta(sql);

            return mapping(dataTable.Rows[0]);
        }



        public List<Itinerario> getAll()
        {
            string sql = "SELECT * FROM ITINERARIOS";
            DataTable dataTable = accesoBD.ejecutarConsulta(sql);
            List<Itinerario> itinerariosList = new List<Itinerario>();

            if (dataTable.Rows.Count != 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    
                    DataRow row = dataTable.Rows[i];
                    Itinerario itinerario = mapping(row);
                    itinerariosList.Add(itinerario);
                }
            }
            return itinerariosList;
        }

        private int getLastItinerarioInsertId()
        {
            string sql = "SELECT IDENT_CURRENT " + "(" + "'" + "ITINERARIOS" + "'" + ")" + "AS id";
            DataTable dataTable = accesoBD.ejecutarConsulta(sql);
            int id = Convert.ToInt32(dataTable.Rows[0]["id"]);

            return id;

        }



        internal bool create(Itinerario itinerario)
        {
            string strSQL = "INSERT INTO ITINERARIOS (Descripcion, Categoria) " +
                " VALUES (" +
                "'" + itinerario.Descripcion + "'" + "," +
                "'" + itinerario.Categoria + "'" + ")";
            
            BE_acceso_BD.estado_BE estado = accesoBD.insertar(strSQL);

            return verifyState(estado);
        }

        internal bool update(Itinerario itinerario)
        {
            string strSQL = "UPDATE ITINERARIOS " +
                             " SET Descripcion=" + "'" + itinerario.Descripcion + "'" + "," +
                             " Categoria=" + "'" + itinerario.Categoria + "'" + "," +
                             " WHERE Cod_itinerario=" + itinerario.IdItinerario;

            BE_acceso_BD.estado_BE estado = accesoBD.modificar(strSQL);

            return verifyState(estado);
        }
            


        internal bool delete(Itinerario itinerario)
        {
            return this.deleteById(itinerario.IdItinerario);
        }


        internal bool deleteById(int id)
        {
            string sql = "DELETE FROM ITINERARIOS WHERE Cod_itinerario = " + id;
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
        










            
              

       






