using ProyectoPAV.entidades;
using ProyectoPAV.gui.reportes;
using ProyectoPAV.negocio.servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.controllers
{
    class GenerarListadoNavioController
    {
        private int idTipoNavio, minCantPasajeros, maxCantPasajeros;
        private bool check;
        private List<Navio> navios;
        

        private static NavioService navioService = new NavioService();
        
        public GenerarListadoNavioController()
        {
            idTipoNavio = 0;
            navios = new List<Navio>();
           
        }

        public void tomarSeleccionTipoNavio(int idTipoNavio)
        {
            this.idTipoNavio = idTipoNavio; 
        }

        public void tomarSeleccionCantPasajeros(int min, int max)
        {
            this.minCantPasajeros = min;
            this.maxCantPasajeros = max;
        }
        
        public void tomarSeleccionBuscarTodos(bool check)
        {
            this.check = check;
        }

        public DataTable tomarConfirmacionGenerarListado()
        {
            navios = navioService.GetAll();
            if (this.check)
            {
                return this.generarListado();
            }
            else
            {
                if (this.idTipoNavio != 0)
                {
                    this.filtrarNaviosPorTipo();
                }
                return this.generarListado();
            }
            
            
            
        }

        private void filtrarNaviosPorTipo()
        {
            foreach(Navio navio in navios.ToList())
            {
                if(navio.IdTipoClasificacion != idTipoNavio)
                {
                    navios.Remove(navio);
                }
            }
        }

        private DataTable generarListado()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Cod_navio", typeof(Int32));
            dataTable.Columns.Add("Nombre_navio", typeof(string));
            dataTable.Columns.Add("Altura", typeof(Int32));
            dataTable.Columns.Add("Autonomia", typeof(Int32));
            dataTable.Columns.Add("Desplazamiento", typeof(Int32));
            dataTable.Columns.Add("Eslora", typeof(Int32));
            dataTable.Columns.Add("Manga", typeof(Int32));
            dataTable.Columns.Add("Cant_max_pasajeros", typeof(Int32));
            dataTable.Columns.Add("Cant_tripulantes", typeof(Int32));
            dataTable.Columns.Add("Tipo_clasificacion", typeof(string));
            dataTable.Columns.Add("Cant_motores", typeof(Int32));
            foreach (Navio navio in navios)
            {
                DataRow dataRow = dataTable.Rows.Add();
                dataRow.SetField("Cod_navio", navio.CodigoNavio);
                dataRow.SetField("Nombre_navio", navio.Nombre);
                dataRow.SetField("Altura", navio.Altura);
                dataRow.SetField("Autonomia", navio.Autonomia);
                dataRow.SetField("Desplazamiento", navio.Desplazamiento);
                dataRow.SetField("Eslora", navio.Eslora);
                dataRow.SetField("Manga", navio.Manga);
                dataRow.SetField("Cant_max_pasajeros", navio.CantMaxPasjeros);
                dataRow.SetField("Cant_tripulantes", navio.CantTripulantes);
                dataRow.SetField("Tipo_clasificacion", navio.GetTipoNavio().Descripcion);
                dataRow.SetField("Cant_motores", navio.CantMotores);
            }
            return dataTable;
        }




     
       
    }
}
