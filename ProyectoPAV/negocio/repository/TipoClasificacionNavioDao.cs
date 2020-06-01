using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository
{
    class TipoClasificacionNavioDao
    {
        private static BE_acceso_BD accesoBD;


        public TipoClasificacionNavioDao(){
            accesoBD = new BE_acceso_BD();
        }

        //private TipoClasificacionNavio mapping(DataRow row)
        //{
        //    int codigoTipo = row["Cod_clasificacion"];
        //    string descripcion = row["Descripcion"].ToString();

        //    TipoClasificacionNavio tipo = new TipoClasificacionNavio(codigoTipo, descripcion);

        //    return tipo;
        //}

        public DataTable consultar_x_nombre(string nombre)
        {

            string sql = @"SELECT * FROM CLASIFICACION_NAVIO WHERE Descripcion like '%" + nombre + "%'";
            return accesoBD.ejecutarConsulta(sql);

        }

        public DataTable consultarTodos()
        {

            string sql = @"SELECT * FROM CLASIFICACION_NAVIO";
            return accesoBD.ejecutarConsulta(sql);

        }

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
            string strSQL = "UPDATE CLASIFICACION_NAVIO " +
                " SET Descripcion= " +  "'" + tipoClasificacion.Descripcion + "'" +
                " WHERE Cod_clasificacion =" + tipoClasificacion.CodigoClasificacion;
                

            accesoBD.ejecutarConsulta(strSQL);
            return true;
        }

        internal bool delete(int id)
        {
            string strSQL = "DELETE FROM CLASIFICACION_NAVIO " +
                                " WHERE Cod_clasificacion =" + id;
            try
            {
                accesoBD.ejecutarConsulta(strSQL);
                return true;
            }catch(OleDbException e)
            {
                throw;
            }
                        
        }

        


    }
}
