using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.entidades
{
    class Navio
    {
        int codigoNavio;
        string nombre = "";
        float altura = 0.0f;
        float autonomia = 0.0f;
        float desplazamiento = 0.0f;
        float eslora = 0.0f;
        float manga = 0.0f;
        int cantMaxPasjeros = 0;
        int cantTripulantes = 0;
        int tipoClasificacion = 0;
        int cantMotores = 0;

        public Navio(int codigoNavio, string nombre, float altura, float autonomia, float desplazamiento, float eslora, float manga, int cantMaxPasjeros, int cantTripulantes, int tipoClasificacion, int cantMotores)
        {
            this.codigoNavio = codigoNavio;
            this.nombre = nombre;
            this.altura = altura;
            this.autonomia = autonomia;
            this.desplazamiento = desplazamiento;
            this.eslora = eslora;
            this.manga = manga;
            this.cantMaxPasjeros = cantMaxPasjeros;
            this.cantTripulantes = cantTripulantes;
            this.tipoClasificacion = tipoClasificacion;
            this.cantMotores = cantMotores;
        }

        public Navio(string nombre, float altura, float autonomia, float desplazamiento, float eslora, float manga, int cantMaxPasjeros, int cantTripulantes, int tipoClasificacion, int cantMotores)
        {
            this.nombre = nombre;
            this.altura = altura;
            this.autonomia = autonomia;
            this.desplazamiento = desplazamiento;
            this.eslora = eslora;
            this.manga = manga;
            this.cantMaxPasjeros = cantMaxPasjeros;
            this.cantTripulantes = cantTripulantes;
            this.tipoClasificacion = tipoClasificacion;
            this.cantMotores = cantMotores;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public float Altura { get => altura; set => altura = value; }
        public float Autonomia { get => autonomia; set => autonomia = value; }
        public float Desplazamiento { get => desplazamiento; set => desplazamiento = value; }
        public float Eslora { get => eslora; set => eslora = value; }
        public float Manga { get => manga; set => manga = value; }
        public int CantMaxPasjeros { get => cantMaxPasjeros; set => cantMaxPasjeros = value; }
        public int CantTripulantes { get => cantTripulantes; set => cantTripulantes = value; }
        public int TipoClasificacion { get => tipoClasificacion; set => tipoClasificacion = value; }
        public int CantMotores { get => cantMotores; set => cantMotores = value; }
        public int CodigoNavio { get => codigoNavio; set => codigoNavio = value; }
    }
}
