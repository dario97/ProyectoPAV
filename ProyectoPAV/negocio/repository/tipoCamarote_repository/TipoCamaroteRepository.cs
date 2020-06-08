using ProyectoPAV.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV.negocio.repository.tipoCamarote_repository
{
    class TipoCamaroteRepository : IRepository<TipoCamarote, int>
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

        public void Create(TipoCamarote tipoCamarote)
        {
            string sql = "INSERT INTO TIPO_CAMAROTE (Nombre)" +
                "VALUES (" +
                "'" + tipoCamarote.Nombre + "'" + ")";

            dbAccess.insertar(sql);
        }

        public void DeleteById(int id)
        {
            string strSQL = "DELETE FROM TIPO_CAMAROTE " +
                                " WHERE Tipo = " + id;

            dbAccess.borrar(strSQL);
        }

        public List<TipoCamarote> GetAll()
        {
            string sql = "SELECT * FROM TIPO_CAMAROTE";
            DataTable table = dbAccess.ejecutarConsulta(sql);
            List<TipoCamarote> tipos = new List<TipoCamarote>();

            if (ContainRows(table))
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    TipoCamarote tipo = Mapping(table.Rows[i]);
                    tipos.Add(tipo);
                }
            }
            return tipos;
        }
        public TipoCamarote GetById(int id)
        {
            string sql = "SELECT* FROM TIPO_CAMAROTE WHERE Tipo= " + id;
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

        public List<TipoCamarote> GetByName(string name)
        {
            string sql = "SELECT * FROM TIPO_CAMAROTE WHERE Nombre= " + "'" + name + "'";
            DataTable table =dbAccess.ejecutarConsulta(sql);
            List<TipoCamarote> tipos = new List<TipoCamarote>();

            if (ContainRows(table))
            {
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    TipoCamarote tipoCamarote = Mapping(table.Rows[i]);
                    tipos.Add(tipoCamarote);
                }
            }

            return tipos;
        }
        public TipoCamarote Mapping(DataRow row)
        {
            int idTipo = Convert.ToInt32(row["Tipo"].ToString());
            string nombre = row["Nombre"].ToString();

            return new TipoCamarote(idTipo, nombre);
        }

        public void Update(TipoCamarote tipoCamarote)
        {
            string strSQL = "UPDATE TIPO_CAMAROTE " +
                             "SET Nombre=" + "'" + tipoCamarote.Nombre + "'" + "," +
                            " WHERE Tipo=" + tipoCamarote.IdTipo;

            dbAccess.modificar(strSQL);
        }
    }
}
        


            


