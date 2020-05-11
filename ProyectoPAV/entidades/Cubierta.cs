using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.entidades
{
    public class Cubierta
    {
        int id = 0;
        int idNavio = 0;
        int numCubierta = 0; 
        string descripcion = "";
        int legajoEncargado = 0;

        public Cubierta(int id, int idNavio, int numCubierta, string descripcion, int legajoEncargado)
        {
            this.id = id;
            this.idNavio = idNavio;
            this.numCubierta = numCubierta;
            this.descripcion = descripcion;
            this.legajoEncargado = legajoEncargado;
        }

        public Cubierta(int idNavio, int numCubierta, string descripcion, int legajoEncargado)
        {
            this.idNavio = idNavio;
            this.numCubierta = numCubierta;
            this.descripcion = descripcion;
            this.legajoEncargado = legajoEncargado;
        }

        public int IdNavio { get => idNavio; set => idNavio = value; }
        public int NumCubierta { get => numCubierta; set => numCubierta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int LegajoEncargado { get => legajoEncargado; set => legajoEncargado = value; }
    }
}
