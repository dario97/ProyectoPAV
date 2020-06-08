using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository.cubierta_repository
{
    class CubiertaRepository : IRepository<Cubierta, int>
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

        public void Create(Cubierta cubierta)
        {
            string sql;
            if (cubierta.LegajoEncargado == 0)
            {
                sql = "INSERT INTO CUBIERTAS (Cod_navio, Num_cubierta, Descripcion, Leg_encargado)" +
                " VALUES (" +
                "'" + cubierta.IdNavio + "'" + "," + "'" + cubierta.NumCubierta + "'" + "," + "'" + cubierta.Descripcion + "'" + "," +
                "'" + null + "'" + ")";

            }
            else
            {
                sql = "INSERT INTO CUBIERTAS (Cod_navio, Num_cubierta, Descripcion, Leg_encargado)" +
                " VALUES (" +
                "'" + cubierta.IdNavio + "'" + "," + "'" + cubierta.NumCubierta + "'" + "," + "'" + cubierta.Descripcion + "'" + "," +
                "'" + cubierta.LegajoEncargado + "'" + ")";
            }


            dbAccess.insertar(sql);
        }

        public void DeleteById(int id)
        {
            string strSQL = "DELETE FROM CUBIERTAS " +
                                " WHERE id = " + id;

            dbAccess.borrar(strSQL);
        }

        public List<Cubierta> GetAll()
        {
            string sql = "SELECT * FROM CUBIERTAS";
            DataTable table = dbAccess.ejecutarConsulta(sql);
            List<Cubierta> cubiertas = new List<Cubierta>();

            if (ContainRows(table))
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    Cubierta cubierta = Mapping(table.Rows[i]);
                    cubiertas.Add(cubierta);
                }
            }
            return cubiertas;
        }
        public Cubierta GetById(int id)
        {
            string sql = "SELECT* FROM CUBIERTAS WHERE id= " + id;
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

        public Cubierta GetByPrimaryKey(int idNavio, int numCubierta)
        {
            string sql = "SELECT* FROM CUBIERTAS WHERE Cod_navio= " + idNavio + " AND " + " Num_cubierta= " + numCubierta;
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


        public Cubierta Mapping(DataRow row)
        {
            int id = Convert.ToInt32(row["id"].ToString());
            int idNavio = Convert.ToInt32(row["Cod_navio"].ToString());
            int numCubierta = Convert.ToInt32(row["Num_cubierta"].ToString());
            string descripcion = row["Descripcion"].ToString();
            int idEncargado = Convert.ToInt32(row["Leg_encargado"].ToString());

            return new Cubierta(id, idNavio, numCubierta, descripcion, idEncargado);
        }
        public void Update(Cubierta cubierta)
        {
            string strSQL = "UPDATE CUBIERTAS " +
                             "SET Cod_navio=" + "'" + cubierta.IdNavio + "'" + "," +
                             " Num_cubierta=" + "'" + cubierta.NumCubierta + "'" + "," +
                             " Descripcion=" + "'" + cubierta.Descripcion + "'" + "," +
                             " Leg_encargado=" + "'" + cubierta.LegajoEncargado + "'" + "," +
                             " WHERE Cod_navio=" + cubierta.IdNavio + " AND " + "Num_cubierta=" + cubierta.NumCubierta;

            dbAccess.modificar(strSQL);
        }
    }
}





       



