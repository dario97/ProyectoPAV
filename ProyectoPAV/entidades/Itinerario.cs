using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.entidades
{
    public class Itinerario
    {
        int idItinerario;
        string descripcion;
        string categoria;
        List<Escala> escalas;

        public Itinerario(int idItinerario, string descripcion, string categoria, List<Escala> escalas)
        {
            this.idItinerario = idItinerario;
            this.descripcion = descripcion;
            this.categoria = categoria;
            this.escalas = escalas;
        }

        public Itinerario(int idItinerario, string descripcion, string categoria)
        {
            this.idItinerario = idItinerario;
            this.descripcion = descripcion;
            this.categoria = categoria;
            this.escalas = new List<Escala>();
        }

        public Itinerario(string descripcion, string categoria)
        {
            
            this.descripcion = descripcion;
            this.categoria = categoria;
            
        }

        public Itinerario(string descripcion, string categoria, List<Escala> escalas)
        {
            
            this.descripcion = descripcion;
            this.categoria = categoria;
            this.escalas = escalas;
        }

        public void addEscala(Escala escala)
        {
            this.escalas.Add(escala);
        }
        public int IdItinerario { get => idItinerario; set => idItinerario = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public List<Escala> Escalas { get => escalas; set => escalas = value; }





    }
}
