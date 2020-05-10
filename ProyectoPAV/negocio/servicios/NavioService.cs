using ProyectoPAV.entidades;
using ProyectoPAV.negocio.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.servicios
{
    public class NavioService
    {
        private static NavioDao navioDao;

        public NavioService()
        {
            navioDao = new NavioDao();
        }


        internal Navio getById(int id)
        {
            return navioDao.getById(id);
        }
        internal DataTable consultarPorNombre(string nombre)
        {
            return navioDao.consultar_x_nombre(nombre);
        }

        internal DataTable consultarTodos()
        {
            return navioDao.consultarTodos();
        }

        internal bool crearNavio(Navio navio)
        {
            return navioDao.create(navio);
        }

        internal bool modificarNavio(Navio navio)
        {
            return navioDao.update(navio);
        }

        internal bool eliminarNavio(int id)
        {
            return navioDao.delete(id);
        }



    }
}
