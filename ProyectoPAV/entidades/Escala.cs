using ProyectoPAV.negocio.repository;
using ProyectoPAV.negocio.servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV.entidades
{
    public class Escala
    {
        int id;
        int idItinerario;
        int numEscala;
        int idPuerto;

        public Escala(int id, int idItinerario, int numEscala, int idPuerto) 
        {
            this.id = id;
            this.idItinerario = idItinerario;
            this.numEscala = numEscala;
            this.idPuerto = idPuerto;
        }

        public Escala(int idItinerario, int numEscala, int idPuerto)
        {
            this.idItinerario = idItinerario;
            this.numEscala = numEscala;
            this.idPuerto = idPuerto;
        }

        public Escala(int numEscala, int idPuerto)
        {
            this.numEscala = numEscala;
            this.idPuerto = idPuerto;
        }

        public int IdItinerario { get => idItinerario; set => idItinerario = value; }
        public int NumEscala { get => numEscala; set => numEscala = value; }
        public int IdPuerto { get => idPuerto; set => idPuerto = value; }
        public int Id { get => id; set => id = value; }

        public Itinerario getItinerario()
        {
            ItinerarioService itinerarioService = new ItinerarioService();
            return itinerarioService.GetById(this.IdItinerario);
        }
        public Puerto getPuerto()
        {
            PuertoService puertoService = new PuertoService();

            return puertoService.GetById(this.IdPuerto);
        }

    }
}


