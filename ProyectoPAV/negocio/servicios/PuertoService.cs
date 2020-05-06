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
    class PuertoService
    {
        private static PuertoDao puertoDao;

        public PuertoService()
        {
            puertoDao = new PuertoDao();
        }

        internal DataTable consultarPorNombre(string nombre)
        {
            return puertoDao.consultar_x_nombre(nombre);

        }

        internal DataTable consultarTodos()
        {
            return puertoDao.consultarTodos();
        }

        internal bool crearPuerto(Puerto puerto)
        {
            return puertoDao.create(puerto);
        }

        internal bool modificarPuerto(Puerto puerto)
        {
            return puertoDao.update(puerto);
        }

        internal bool eliminarPuerto(int id)
        {
            return puertoDao.delete(id);
        }
    }
}
