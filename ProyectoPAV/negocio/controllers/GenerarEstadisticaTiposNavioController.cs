using ProyectoPAV.negocio.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.controllers
{
    class GenerarEstadisticaTiposNavioController
    {
        private static BE_acceso_BD dbAccess = new BE_acceso_BD();
        private List<string> legendsLabels;
        private List<int> values;
        public GenerarEstadisticaTiposNavioController()
        {
            legendsLabels = new List<string>();
            values = new List<int>();
        }

        public void calcularEstadisticas()
        {
            string sql = @"SELECT Tipo_clasificacion, Descripcion, COUNT(Cod_navio) AS count
                            FROM NAVIOS JOIN CLASIFICACION_NAVIO ON Tipo_clasificacion = Cod_clasificacion
                            GROUP BY Tipo_clasificacion, Descripcion";

            DataTable table = dbAccess.ejecutarConsulta(sql);

            for(int i = 0; i < table.Rows.Count; i++)
            {
                string tipoNavio = table.Rows[i]["Descripcion"].ToString();
                int countNavioByTipoNavio = Convert.ToInt32(table.Rows[i]["count"]);
                
                legendsLabels.Add(tipoNavio);
                values.Add(countNavioByTipoNavio);
            }
        }

        public List<String> getLegends()
        {
            return legendsLabels;
        }

        public List<int> getValues()
        {
            return values;
        }
    }
}
   

                

