using ProyectoPAV.entidades;
using ProyectoPAV.negocio.repository;
using ProyectoPAV.negocio.repository.cubierta_repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.servicios
{
    class CubiertaService
    {
        private static CubiertaRepository cubiertaRepository = new CubiertaRepository();
     
        internal Cubierta GetById(int id)
        {
            return cubiertaRepository.GetById(id);
        }

        internal List<Cubierta> GetAll()
        {
            return cubiertaRepository.GetAll();
        }

        internal Cubierta GetByPrimaryKey(int idNavio, int numCubierta)
        {
            return cubiertaRepository.GetByPrimaryKey(idNavio, numCubierta);
        }

        internal void CrearCubierta(Cubierta cubierta)
        {
            cubiertaRepository.Create(cubierta);
        }

        internal void ModificarCubierta(Cubierta cubierta)
        {
            cubiertaRepository.Update(cubierta);
        }

        internal void DeleteById(int id)
        {
            cubiertaRepository.DeleteById(id);
        }
    }
}
