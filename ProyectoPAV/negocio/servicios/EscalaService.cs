using ProyectoPAV.entidades;
using ProyectoPAV.negocio.repository;
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

        public EscalaService()
        {
            this.escalaDao = new EscalaDao();
        }


        //internal bool cargarItinerario(Itinerario itinerario)
        //{
        //    return itinerarioDao.cargarItinerario(itinerario);
        //}

        internal bool create(Escala escala)
        {
            return escalaDao.create(escala);
        }

        internal Escala getById(int id)
        {
            return escalaDao.getById(id);

        }

        internal List<Escala> getAll()
        {
            return escalaDao.getAll();

        }

        internal bool deleteById(int id)
        {
            return escalaDao.deleteById(id);
        }

        internal bool delete(Escala escala)
        {
            return escalaDao.delete(escala);
        }

        internal bool update(Escala escala)
        {
            return escalaDao.update(escala);
        }
    }
}
