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
        
        private static NavioRepository navioRepository = new NavioRepository();

        internal Navio GetById(int id)
        {
            return navioRepository.GetById(id);
        }
        internal List<Navio> GetByName(string name)
        {
            return navioRepository.GetByName(name);
        }

        internal List<Navio> GetAll()
        {
            return navioRepository.GetAll();
        }

        internal void CreateNavio(Navio navio)
        {
            navioRepository.Create(navio);
        }

        internal void UpdateNavio(Navio navio)
        {
             navioRepository.Update(navio);
        }

        internal void DeleteNavioById(int id)
        {
            navioRepository.DeleteById(id);
        }
    }
}



