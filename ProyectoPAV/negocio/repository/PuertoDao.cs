using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository
{
    class PuertoDao
    {
        private static BE_acceso_BD accesoBD;

        public PuertoDao()
        {
            accesoBD = new BE_acceso_BD();
        }

        private Puerto mapping(DataRow row)
        {
            int codPuerto = row["Cod_puerto"];
            string nombre = row["Nombre"].ToString();
               
            Puerto puerto = new Puerto(codPuerto, nombre);

            return puerto;
        }
            

        internal bool create(Puerto puerto)
        {
            string strSQL = "INSERT INTO PUERTOS (Nombre)" +
                " VALUES (" +
                "'" + puerto.Nombre + "'" + ")";

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }

        internal bool update(Puerto puerto)
        {
            string strSQL = "UPDATE PUERTOS " +
                             "SET Nombre=" + "'" + puerto.Nombre + "'" +
                             " WHERE Cod_puerto=" + puerto.CodigoPuerto;

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }

        internal bool delete(Puerto puerto)
        {
            string strSQL = "DELETE FROM PUERTOS " +
                                " WHERE Cod_puerto =" + puerto.CodigoPuerto;

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }




    }
}
