﻿using ProyectoPAV.entidades;
using ProyectoPAV.negocio.repository;
using System;
using System.Collections.Generic;
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

        internal bool crearPuerto(Puerto puerto)
        {
            return puertoDao.create(puerto);
        }

        internal bool modificarPuerto(Puerto puerto)
        {
            return puertoDao.update(puerto);
        }

        internal bool eliminarPuerto(Puerto puerto)
        {
            return puertoDao.delete(puerto);
        }
    }
}
