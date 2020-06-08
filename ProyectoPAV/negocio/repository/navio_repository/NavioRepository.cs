using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository
{
    class NavioRepository : IRepository<Navio, int>
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

        public void Create(Navio navio)
        {
            string strSQL = "INSERT INTO NAVIOS (Nombre_navio, Altura, Autonomia, Desplazamiento, Eslora, Manga, Cant_max_pasajeros, Cant_tripulantes, Tipo_clasificacion, Cant_motores)" +
                "VALUES (" +
                "'" + navio.Nombre + "'" + "," +
                "'" + navio.Altura + "'" + "," +
                "'" + navio.Autonomia + "'" + "," +
                "'" + navio.Desplazamiento + "'" + "," +
                "'" + navio.Eslora + "'" + "," +
                "'" + navio.Manga + "'" + "," +
                "'" + navio.CantMaxPasjeros + "'" + "," +
                "'" + navio.CantTripulantes + "'" + "," +
                "'" + navio.IdTipoClasificacion + "'" + "," +
                "'" + navio.CantMotores + "'" + ")";

            dbAccess.insertar(strSQL);
        }

        public void DeleteById(int id)
        {
            string strSQL = "DELETE FROM NAVIOS " +
                                " WHERE Cod_navio =" + id;
            dbAccess.borrar(strSQL);
        }

        public List<Navio> GetAll()
        {
            string sql = @"SELECT * FROM NAVIOS";
            DataTable table = dbAccess.ejecutarConsulta(sql);
            List<Navio> navios = new List<Navio>();

            if (table.Rows.Count != 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    Navio navio = Mapping(row);
                    navios.Add(navio);
                }
            }
            return navios;
        }

        public Navio GetById(int id)
        {
            string sql = @"SELECT * FROM NAVIOS WHERE Cod_navio= " + id;
            DataTable table = dbAccess.ejecutarConsulta(sql);

            if(ContainRows(table))
            {
                return Mapping(table.Rows[ELEMENT_WITH_THAT_ID]);
            }
            else
            {
                return null;
            }
        }

        public List<Navio> GetByName(string name)
        {
            string sql = @"SELECT * FROM NAVIOS WHERE Nombre_navio like '%" + name + "%'";
            DataTable table = dbAccess.ejecutarConsulta(sql);
            List<Navio> navios = new List<Navio>();
            if (ContainRows(table))
            {
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    Navio navio = Mapping(table.Rows[i]);
                    navios.Add(navio);
                }
            }

            return navios;
        }
            

        public Navio Mapping(DataRow row)
        {
            int idNavio = Convert.ToInt32(row["Cod_navio"].ToString());
            string nombre = row["Nombre_navio"].ToString();
            float altura = Convert.ToSingle(row["Altura"].ToString());
            float autonomia = Convert.ToSingle(row["Autonomia"].ToString());
            float desplazamiento = Convert.ToSingle(row["Desplazamiento"].ToString());
            float eslora = Convert.ToSingle(row["Eslora"].ToString());
            float manga = Convert.ToSingle(row["Manga"].ToString());
            int cantPasajeros = Convert.ToInt32(row["Cant_max_pasajeros"].ToString());
            int cantTripulantes = Convert.ToInt32(row["Cant_tripulantes"].ToString());
            int idTipoClasificacion = Convert.ToInt32(row["Tipo_clasificacion"].ToString());
            int cantMotores = Convert.ToInt32(row["Cant_motores"].ToString());

            Navio navio = new Navio(idNavio, nombre, altura, autonomia, desplazamiento, eslora, manga, cantPasajeros, cantTripulantes, idTipoClasificacion, cantMotores);

            return navio;
        }

        public void Update(Navio navio)
        {
            string strSQL = "UPDATE NAVIOS " +
                             "SET Nombre_navio=" + "'" + navio.Nombre + "'" + "," +
                             " Altura=" + "'" +navio.Altura + "'" + "," +
                             " Autonomia=" + "'" + navio.Autonomia + "'" + "," +
                             " Desplazamiento=" + "'" + navio.Desplazamiento + "'" + "," +
                             " Eslora=" + "'" + navio.Eslora + "'" + "," +
                             " Manga=" + "'" + navio.Manga + "'" + "," +
                             " Cant_max_pasajeros=" + "'" + navio.CantMaxPasjeros + "'" + "," +
                             " Cant_tripulantes=" + "'" + navio.CantTripulantes + "'" + "," +
                             " Tipo_clasificacion=" + "'" + navio.IdTipoClasificacion + "'" + "," +
                             " Cant_motores=" + "'" + navio.CantMotores + "'" +
                             " WHERE Cod_navio=" + navio.CodigoNavio;

            dbAccess.modificar(strSQL);
        }
    }
}
