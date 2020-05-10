using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.entidades
{
    
    public class TipoCamarote
    {
        private int idTipo;
        private string nombre;

        public int IdTipo { get => idTipo; set => idTipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public TipoCamarote(int idTipo, string nombre)
        {
            this.IdTipo = idTipo;
            this.Nombre = nombre;
        }

        public TipoCamarote(string nombre)
        {
            this.Nombre = nombre;
        }
    

    }
}
