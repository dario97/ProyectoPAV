using ProyectoPAV.entidades;
using ProyectoPAV.negocio.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.servicios
{
    public class ItinerarioService
    {
        private ItinerarioDao itinerarioDao;

        public ItinerarioService()
        {
            this.itinerarioDao = new ItinerarioDao();
        }

        internal bool cargarItinerario(Itinerario itinerario)
        {
            return itinerarioDao.cargarItinerario(itinerario);
        }
        internal bool create(Itinerario itinerario)
        {
            return itinerarioDao.create(itinerario);
        }

        internal Itinerario getById(int id)
        {
            return itinerarioDao.getById(id);

        }

        internal List<Itinerario> getAll()
        {
            return itinerarioDao.getAll();
           
        }

        internal bool deleteById(int id)
        {
            return itinerarioDao.deleteById(id);
        } 

        internal bool delete(Itinerario itinerario)
        {
            return itinerarioDao.delete(itinerario);
        }

        internal bool update(Itinerario itinerario)
        {
            return itinerarioDao.update(itinerario);
        }

    }
}
