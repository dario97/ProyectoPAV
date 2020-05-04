using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository
{
    class NavioDao
    {
        BE_acceso_BD accesoBD = new BE_acceso_BD();

        private bool create(Navio navio)
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

        private bool update(Navio navio)
        {
            string strSQL = "UPDATE Productos " +
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
                             " WHERE id_producto=" + navio.CodigoNavio;

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }







    }
}
