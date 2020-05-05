using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository
{
    class TipoClasificacionNavioDao
    {
        BE_acceso_BD accesoBD = new BE_acceso_BD();



        internal bool create(TipoClasificacionNavio tipoClasificacion)
        {
            string strSQL = "INSERT INTO CLASIFICACION_NAVIO (Descripcion)" +
                "VALUES (" +
                "'" + tipoClasificacion.Descripcion + "'" + ")";

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }

        internal bool update(TipoClasificacionNavio tipoClasificacion)
        {
            string strSQL = "UPDATE CLASIFICACION_NAVIO (Descripcion)" +
                "SET Descripcion=" + tipoClasificacion.Descripcion +
                " WHERE Cod_clasificacion =" + tipoClasificacion.CodigoClasificacion;
                

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }

        internal bool delete(TipoClasificacionNavio tipoClasificacion)
        {
            string strSQL = "DELETE FROM CLASIFICACION_NAVIO " +
                                " WHERE Cod_clasificacion =" + tipoClasificacion.CodigoClasificacion;

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }

        


    }
}
