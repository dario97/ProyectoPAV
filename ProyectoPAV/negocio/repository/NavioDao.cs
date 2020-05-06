using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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


        //private Navio mapping(DataRow row)
        //{
        //    int codigoNavio = Convert.ToInt32(row["Cod_navio"]);
        //    string nombre = row["Nombre_navio"].ToString();
        //    float altura = Convert.ToSingle(row["Altura"]);
        //    float autonomia = Convert.ToSingle(row["Autonomia"]);
        //    float desplazamiento = Convert.ToSingle(row["Desplazamiento"]);
        //    float eslora = Convert.ToSingle(row["Eslora"]);
        //    float manga = Convert.ToSingle(row["Manga"]);
        //    int cantMaxPasajeros = Convert.ToInt32(row["Cant_max_pasajeros"]);
        //    int cantTripulantes = Convert.ToInt32(row["Cant_tripulantes"]);
        //    int tipoClasificacion = Convert.ToInt32(row["Tipo_clasificacion"]);
        //    int cantMotores = Convert.ToInt32(row["Cant_motores"]);

        //    Navio navio = new Navio(codigoNavio, nombre, altura, autonomia, desplazamiento, eslora, manga, cantMaxPasajeros, cantTripulantes, tipoClasificacion, cantMotores);

        //    return navio;
        //}


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

            





            

