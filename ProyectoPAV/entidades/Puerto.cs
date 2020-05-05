using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.entidades
{
    class Puerto
    {
        private int codigoPuerto;
        private string nombre;

        public Puerto(int codigoPuerto, string nombre)
        {
            this.CodigoPuerto = codigoPuerto;
            this.Nombre = nombre;
        }

        public int CodigoPuerto { get => codigoPuerto; set => codigoPuerto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
