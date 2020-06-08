using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ProyectoPAV.negocio.repository.tipoNavio_repository
{
    class TipoNavioRepository : IRepository<TipoClasificacionNavio, int>
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
        public void Create(TipoClasificacionNavio tipo)
        {
            string strSQL = "INSERT INTO CLASIFICACION_NAVIO (Descripcion)" +
                "VALUES (" +
                "'" + tipo.Descripcion + "'" + ")";

            dbAccess.insertar(strSQL);
        }

        public void DeleteById(int id)
        {
            string strSQL = "DELETE FROM CLASIFICACION_NAVIO " +
                                " WHERE Cod_clasificacion =" + id;
            try
            {
                dbAccess.borrar(strSQL);
                
            }
            catch (OleDbException e)
            {
                throw e;
            }
        }

        public List<TipoClasificacionNavio> GetAll()
        {
            string sql = @"SELECT * FROM CLASIFICACION_NAVIO";
            DataTable table = dbAccess.ejecutarConsulta(sql);
            List<TipoClasificacionNavio> tipos = new List<TipoClasificacionNavio>();

            if (ContainRows(table))
            {
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    TipoClasificacionNavio tipo = Mapping(table.Rows[i]);
                    tipos.Add(tipo);
                }
            }

            return tipos;
        }
            

        public TipoClasificacionNavio GetById(int id)
        {
            string sql = "SELECT * FROM CLASIFICACION_NAVIO WHERE Cod_clasificacion=" + id;
            DataTable  table = dbAccess.ejecutarConsulta(sql);

            if (ContainRows(table))
            {
                return Mapping(table.Rows[ELEMENT_WITH_THAT_ID]);
            }
            else
            {
                return null;
            }
        }

        public List<TipoClasificacionNavio> GetByName(string name)
        {
            string sql = @"SELECT * FROM CLASIFICACION_NAVIO WHERE Descripcion like '%" + name + "%'";
            DataTable table = dbAccess.ejecutarConsulta(sql);
            List<TipoClasificacionNavio> tiposNavios = new List<TipoClasificacionNavio>();

            if (ContainRows(table))
            {
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    TipoClasificacionNavio tipoNavio = Mapping(table.Rows[i]);
                    tiposNavios.Add(tipoNavio);
                }
            }

            return tiposNavios;
            
        }

        public TipoClasificacionNavio Mapping(DataRow row)
        {
            int idTipo = Convert.ToInt32(row["Cod_clasificacion"].ToString());
            string descripcion = row["Descripción"].ToString();

            return new TipoClasificacionNavio(idTipo, descripcion);
        }

        public void Update(TipoClasificacionNavio tipo)
        {
            string strSQL = "UPDATE CLASIFICACION_NAVIO " +
                " SET Descripcion= " + "'" + tipo.Descripcion + "'" +
                " WHERE Cod_clasificacion =" + tipo.CodigoClasificacion;


            dbAccess.modificar(strSQL);
        }
    }
}
