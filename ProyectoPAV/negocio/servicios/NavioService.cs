using ProyectoPAV.entidades;
using ProyectoPAV.negocio.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.servicios
{
    class NavioService
    {
        private static NavioDao navioDao;

        public NavioService()
        {
            navioDao = new NavioDao();
        }

        internal bool crearNavio(Navio navio)
        {
            return navioDao.create(navio);
        }

        internal bool modificarNavio(Navio navio)
        {
            return navioDao.update(navio);
        }

        internal bool eliminarNavio(Navio navio)
        {
            return navioDao.delete(navio);
        }



    }
}
