using ProyectoPAV.entidades;
using ProyectoPAV.negocio.repository;
using ProyectoPAV.negocio.repository.itinerario_repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.servicios
{
    public class ItinerarioService
    {
        
        private static ItinerarioRepository itinerarioRepository = new ItinerarioRepository();

        internal void CargarItinerario(Itinerario itinerario)
        {
          itinerarioRepository.CargarItinerario(itinerario);
        }
        internal void Create(Itinerario itinerario)
        {
            itinerarioRepository.Create(itinerario);
        }

        internal Itinerario GetById(int id)
        {
            return itinerarioRepository.GetById(id);

        }

        internal List<Itinerario> GetAll()
        {
            return itinerarioRepository.GetAll();
           
        }

        internal void DeleteById(int id)
        {
            itinerarioRepository.DeleteById(id);
        } 

        internal void update(Itinerario itinerario)
        {
            itinerarioRepository.Update(itinerario);
        }

    }
}
