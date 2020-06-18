using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.entidades
{
    public class TipoClasificacionNavio
    {
        int codigoClasificacion;
        string descripcion = "";

        public TipoClasificacionNavio(int codigoClasificacion, string descripcion)
        {
            this.codigoClasificacion = codigoClasificacion;
            this.descripcion = descripcion;
        }

        public TipoClasificacionNavio(string descripcion)
        {
            this.descripcion = descripcion;

        }

        public int CodigoClasificacion { get => codigoClasificacion; set => codigoClasificacion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }



    }
}
