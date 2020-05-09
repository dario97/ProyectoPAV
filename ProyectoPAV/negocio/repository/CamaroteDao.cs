using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository
{
    class CamaroteDao
    {
        private static BE_acceso_BD accesoBD;

        public CamaroteDao()
        {

            accesoBD = new BE_acceso_BD();

        }

        public DataTable consultarCamarote(int codNavio, int numCubierta, int numCamarote)
        {

            string sql = @"SELECT * FROM CAMAROTES WHERE Cod_navio = " + codNavio + " AND " + "Num_cubierta = " + numCubierta + " AND " + "Num_camarote = " + numCamarote;
            return accesoBD.ejecutarConsulta(sql);

        }

        public DataTable consultarTodos()
        {

            string sql = @"SELECT * FROM CAMAROTES";
            return accesoBD.ejecutarConsulta(sql);

        }



        internal bool create(Camarote camarote)
        {
            string strSQL = "INSERT INTO CAMAROTES (Cod_navio, Num_cubierta, Num_camarote, Tipo, Ubicacion, Cant_camas)" +
                "VALUES (" +
                "'" + camarote.IdNavio + "'" + "," +
                "'" + camarote.NumCubierta + "'" + "," +
                "'" + camarote.NumCamarote + "'" + "," +
                "'" + camarote.IdTipoCamarote + "'" + "," +
                "'" + camarote.Ubicacion+ "'" + "," +
                "'" + camarote.CantCamas + "'" + "," + ")";

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }

        internal bool update(Camarote camarote)
        {
            string strSQL = "UPDATE CAMAROTES " +
                             "SET Cod_navio=" + "'" + camarote.IdNavio + "'" + "," +
                             " Num_cubierta=" + "'" + camarote.NumCubierta + "'" + "," +
                             " Num_camarote=" + "'" + camarote.NumCamarote + "'" + "," +
                             " Tipo=" + "'" + camarote.IdTipoCamarote + "'" + "," +
                             " Ubicacion=" + "'" + camarote.Ubicacion + "'" + "," +
                             " Cant_camas=" + "'" + camarote.CantCamas + "'" + 
                             " WHERE Cod_navio=" + camarote.IdNavio + " AND " + "Num_cubierta=" + camarote.NumCubierta + " AND " + " Num_camarote=" + camarote.NumCamarote;

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }

        internal bool delete(Camarote camarote)
        {
            string strSQL = "DELETE FROM NAVIOS " +
                                " WHERE Cod_navio =" + camarote.IdNavio + " AND " + "Num_cubierta=" + camarote.NumCubierta + " AND " + "Num_camarote="+ camarote.NumCamarote;



            accesoBD.ejecutarConsulta(strSQL);
            return true;


        }
    }
}
