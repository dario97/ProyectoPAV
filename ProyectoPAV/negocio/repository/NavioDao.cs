using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository
{
    class NavioDao
    {
        private static BE_acceso_BD accesoBD;

        public NavioDao(){
            
            accesoBD = new BE_acceso_BD();
        
        }


        public Navio getById(int id)
        {
            string sql = @"SELECT * FROM NAVIOS WHERE Cod_navio= " + id;
            DataTable data = accesoBD.ejecutarConsulta(sql);
            
            int idNavio = Convert.ToInt32(data.Rows[0]["Cod_navio"].ToString());
            string nombre = data.Rows[0]["Nombre_navio"].ToString();
            float altura = Convert.ToSingle(data.Rows[0]["Altura"].ToString());
            float autonomia = Convert.ToSingle(data.Rows[0]["Autonomia"].ToString());
            float desplazamiento = Convert.ToSingle(data.Rows[0]["Desplazamiento"].ToString());
            float eslora = Convert.ToSingle(data.Rows[0]["Eslora"].ToString());
            float manga = Convert.ToSingle(data.Rows[0]["Manga"].ToString());
            int cantPasajeros = Convert.ToInt32(data.Rows[0]["Cant_max_pasajeros"].ToString());
            int cantTripulantes = Convert.ToInt32(data.Rows[0]["cantTripulantes"].ToString());
            int idTipoClasificacion = Convert.ToInt32(data.Rows[0]["Tipo_clasificacion"].ToString());
            int cantMotores = Convert.ToInt32(data.Rows[0]["Cant_motores"].ToString());

            return new Navio(idNavio, nombre, altura, autonomia, desplazamiento, eslora, manga, cantPasajeros, cantTripulantes, idTipoClasificacion, cantMotores);


        }

        public DataTable consultar_x_nombre(string nombre)
        {
        
            string sql = @"SELECT * FROM NAVIOS WHERE Nombre_navio like '%" + nombre + "%'";
            return accesoBD.ejecutarConsulta(sql);

        }

        public DataTable consultarTodos()
        {

            string sql = @"SELECT * FROM NAVIOS";
            return accesoBD.ejecutarConsulta(sql);

        }



        internal bool create(Navio navio)
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
                "'" + navio.TipoClasificacion + "'" + "," +
                "'" + navio.CantMotores + "'" + ")";

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }

        internal bool update(Navio navio)
        {
            string strSQL = "UPDATE NAVIOS " +
                             "SET Nombre_navio=" + "'" + navio.Nombre + "'" + "," +
                             " Altura=" + "'" + navio.Altura + "'" + "," +
                             " Autonomia=" + "'" + navio.Autonomia + "'" + "," +
                             " Desplazamiento=" + "'" + navio.Desplazamiento + "'" + "," +
                             " Eslora=" + "'" + navio.Eslora + "'" + "," +
                             " Manga=" + "'" + navio.Manga + "'" + "," +
                             " Cant_max_pasajeros=" + "'" + navio.CantMaxPasjeros + "'" + "," +
                             " Cant_tripulantes=" + "'" + navio.CantTripulantes + "'" + "," +
                             " Tipo_clasificacion=" + "'" + navio.TipoClasificacion + "'" + "," +
                             " Cant_motores=" + "'" + navio.CantMotores + "'"  +
                             " WHERE Cod_navio=" + navio.CodigoNavio;

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }

        internal bool delete(int id)
        {
            string strSQL = "DELETE FROM NAVIOS " +
                                " WHERE Cod_navio =" + id;



            accesoBD.ejecutarConsulta(strSQL);
            return true;


        }





    }
}

            





            

