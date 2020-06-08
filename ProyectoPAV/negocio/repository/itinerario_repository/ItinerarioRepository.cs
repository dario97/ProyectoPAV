using ProyectoPAV.entidades;
using ProyectoPAV.negocio.servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository.itinerario_repository
{
    class ItinerarioRepository : IRepository<Itinerario, int>
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

        public void CargarItinerario(Itinerario itinerario)
        {

            dbAccess.iniciar_transaccion();
            this.Create(itinerario);
            int id = GetLastItinerarioInsertId();

            List<Escala> escalas = new List<Escala>(itinerario.Escalas);
            EscalaService escalaService = new EscalaService();

            for (int i = 0; i < escalas.Count; i++)
            {
                escalas[i].IdItinerario = id;
                escalaService.Create(escalas[i]);
            }
            dbAccess.cerrar_transaccion();
        }

        private static int GetLastItinerarioInsertId()
        {
            string sql = "SELECT IDENT_CURRENT " + "(" + "'" + "ITINERARIOS" + "'" + ")" + "AS id";
            DataTable dataTable = dbAccess.ejecutarConsulta(sql);
            int id = Convert.ToInt32(dataTable.Rows[0]["id"]);

            return id;
        }
        public void Create(Itinerario itinerario)
        {
            string strSQL = "INSERT INTO ITINERARIOS (Descripcion, Categoria) " +
                " VALUES (" +
                "'" + itinerario.Descripcion + "'" + "," +
                "'" + itinerario.Categoria + "'" + ")";

            BE_acceso_BD.estado_BE estado = dbAccess.insertar(strSQL);
        }

        public void DeleteById(int id)
        {
            string sql = "DELETE FROM ITINERARIOS WHERE Cod_itinerario = " + id;
            BE_acceso_BD.estado_BE estado = dbAccess.borrar(sql);
        }

        public List<Itinerario> GetAll()
        {
            string sql = "SELECT * FROM ITINERARIOS";
            DataTable dataTable = dbAccess.ejecutarConsulta(sql);
            List<Itinerario> itinerariosList = new List<Itinerario>();

            if (ContainRows(dataTable))
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Itinerario itinerario = Mapping(dataTable.Rows[i]);
                    itinerariosList.Add(itinerario);
                }
            }
            return itinerariosList;
        }

        public Itinerario GetById(int id)
        {
            string sql = "SELECT * FROM ITINERARIOS WHERE Cod_itinerario= " + id;
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

        public Itinerario Mapping(DataRow row)
        {
            int id = Convert.ToInt32(row["Cod_itinerario"].ToString());
            string descripcion = row["Descripcion"].ToString();
            string categoria = row["Categoria"].ToString();

            return new Itinerario(id, descripcion, categoria);
            
        }

        public void Update(Itinerario itinerario)
        {
            string strSQL = "UPDATE ITINERARIOS " +
                             " SET Descripcion=" + "'" + itinerario.Descripcion + "'" + "," +
                             " Categoria=" + "'" + itinerario.Categoria + "'" + "," +
                             " WHERE Cod_itinerario=" + itinerario.IdItinerario;

            BE_acceso_BD.estado_BE estado = dbAccess.modificar(strSQL);
        }
    }
}
