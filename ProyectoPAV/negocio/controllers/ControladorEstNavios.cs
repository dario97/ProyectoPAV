using ProyectoPAV.negocio.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.controllers
{
    class ControladorEstNavios
    {
        private static BE_acceso_BD dbAccess = new BE_acceso_BD();

        private string campoBusqueda;
        private int topSelected;
        private List<int> values;
        private List<string> navioNames;


        public ControladorEstNavios()
        {
            campoBusqueda = "";
            topSelected = -1;
            values = new List<int>();
            navioNames = new List<string>();
        }

        public void tomarSeleccionCampo(int campo)
        {
            switch (campo)
            {
                case 0:
                    this.campoBusqueda = "Autonomia";
                    break;
                case 1:
                    this.campoBusqueda = "Cant_max_pasajeros";
                    break;
                case 2:
                    this.campoBusqueda = "Cant_tripulantes";
                    break;

            }
            
        }

        public void tomarSeleccionTop(int topSelected)
        {
            this.topSelected = topSelected;
        }

        public List<int> getValues()
        {
            return this.values;
        }

        public void generarEstadisticas()
        {
            BE_acceso_BD dbAccess = new BE_acceso_BD();

            string sql = "SELECT TOP " + this.topSelected + this.campoBusqueda + ", Nombre_navio FROM NAVIOS " +
                         " ORDER BY " + this.campoBusqueda + " DESC ";

 

            DataTable table = dbAccess.ejecutarConsulta(sql);

            for(int i = 0; i < table.Rows.Count; i++)
            {
                string name = table.Rows[i]["Nombre_navio"].ToString();
                int value = Convert.ToInt32(table.Rows[i][this.campoBusqueda]);

                navioNames.Add(name);
                values.Add(value);
            }
        }

        public void generarConsulta()
        {
            

            
            
        }








    }
}
