using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository
{
    public class CubiertaDao
    {
        private static BE_acceso_BD accesoBD;

        public CubiertaDao()
        {
            accesoBD = new BE_acceso_BD();
        }

        public Cubierta consultarCubierta(int codNavio, int numCubierta)
        {
            string sql = "SELECT* FROM CUBIERTAS WHERE Cod_navio= " + codNavio + " AND " + " Num_cubierta= " + numCubierta;
            DataTable data = accesoBD.ejecutarConsulta(sql);
            Cubierta cubierta = null;

            if (data.Rows.Count != 0)
            {
                int id = Convert.ToInt32(data.Rows[0]["id"].ToString());
                string descripcion = data.Rows[0]["Descripcion"].ToString();
                int legajoEncargado = Convert.ToInt32(data.Rows[0]["Leg_encargado"].ToString());

                cubierta = new Cubierta(id, codNavio, numCubierta, descripcion, legajoEncargado);

            }

            return cubierta;

        }
        public Cubierta getById(int id)
        {
            string sql = "SELECT* FROM CUBIERTAS WHERE id= " + id;
            DataTable data = accesoBD.ejecutarConsulta(sql);
            Cubierta cubierta = null;
            
            if(data.Rows.Count != 0)
            {
                int idNavio = Convert.ToInt32(data.Rows[0]["Cod_navio"].ToString());
                int numCubierta = Convert.ToInt32(data.Rows[0]["Num_cubierta"].ToString());
                string descripcion = data.Rows[0]["Descripcion"].ToString();
                int legajoEncargado = Convert.ToInt32(data.Rows[0]["Leg_encargado"].ToString());

                cubierta = new Cubierta(id, idNavio, numCubierta, descripcion, legajoEncargado);

            }

            return cubierta;
                
        }

        public List<Cubierta> getAll()
        {
            string sql = "SELECT * FROM CUBIERTAS";
            DataTable data = accesoBD.ejecutarConsulta(sql);
            List<Cubierta> cubiertasList = new List<Cubierta>();

            if(data.Rows.Count != 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(data.Rows[i]["id"].ToString());
                    int idNavio = Convert.ToInt32(data.Rows[i]["Cod_navio"].ToString());
                    int numCubierta = Convert.ToInt32(data.Rows[i]["Num_cubierta"].ToString());
                    string descripcion = data.Rows[i]["Descripcion"].ToString();
                    int legajoEncargado = Convert.ToInt32(data.Rows[i]["Leg_encargado"].ToString());

                    Cubierta cubierta = new Cubierta(id, idNavio, numCubierta, descripcion, legajoEncargado);

                    cubiertasList.Add(cubierta);
                }

            }
            

            return cubiertasList;
        }

        internal bool delete(int id)
        {
            string strSQL = "DELETE FROM CUBIERTAS " +
                                " WHERE id = " + id;

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }


        public DataTable consultar_x_nombre(string nombre)
        {
            string sql = "SELECT * FROM TIPO_CAMAROTE WHERE Nombre= " + "'" + nombre + "'";
            return accesoBD.ejecutarConsulta(sql);
        }

        public void create(Cubierta cubierta)
        {
            string sql;
            if(cubierta.LegajoEncargado == 0)
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
            
                 
            accesoBD.ejecutarConsulta(sql);
        }
    }
}


