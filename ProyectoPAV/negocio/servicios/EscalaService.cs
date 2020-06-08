using ProyectoPAV.entidades;
using ProyectoPAV.negocio.repository;
using ProyectoPAV.negocio.repository.escala_repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.servicios
{
    public class EscalaService
    {
        EscalaDao escalaDao;
        private static EscalaRepository escalaRepository = new EscalaRepository();
        public EscalaService()
        {
            this.escalaDao = new EscalaDao();
        }

        internal List<Escala> getAllEscalasDeUnItinerario(int id)
        {
            return escalaRepository.GetAllEscalasFromItinerario(id);
        }
        internal void Create(Escala escala)
        {
            escalaRepository.Create(escala);
        }

        internal Escala GetById(int id)
        {
            return escalaRepository.GetById(id);

        }

        internal List<Escala> GetAll()
        {
            return escalaRepository.GetAll();

        }

        internal void DeleteById(int id)
        {
            escalaRepository.DeleteById(id);
        }

        internal void Update(Escala escala)
        {
            escalaRepository.Update(escala);
        }
    }
}
