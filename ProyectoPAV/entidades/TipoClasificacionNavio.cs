using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.entidades
{
    class TipoClasificacionNavio
    {
        int codigoClasificacion = 0;
        string descripcion = "";

        TipoClasificacionNavio()
        {

        }

        public int CodigoClasificacion { get => codigoClasificacion; set => codigoClasificacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }


    }
}
