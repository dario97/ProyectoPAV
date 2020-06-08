using ProyectoPAV.entidades;
using ProyectoPAV.negocio.repository;
using ProyectoPAV.negocio.repository.puerto_repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.servicios
{
    public class PuertoService
    {
        private static PuertoRepository puertoRepository = new PuertoRepository();

        internal Puerto GetById(int id)
        {
            return puertoRepository.GetById(id);
        }

        internal List<Puerto> GetByName(string name)
        {
            return puertoRepository.GetByName(name);
        }

        internal List<Puerto> GetAll()
        {
            return puertoRepository.GetAll();
        }

        internal void CreatePuerto(Puerto puerto)
        {
            puertoRepository.Create(puerto);
        }

        internal void UpdatePuerto(Puerto puerto)
        {
            puertoRepository.Update(puerto);
        }

        internal void DeletePuertoById(int id)
        {
            puertoRepository.DeleteById(id);
        }
    }
}
