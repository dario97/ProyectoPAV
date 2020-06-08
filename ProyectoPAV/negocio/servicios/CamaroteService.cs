using ProyectoPAV.entidades;
using ProyectoPAV.negocio.repository;
using ProyectoPAV.negocio.repository.camarote_repository;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace ProyectoPAV.negocio.servicios
{
    public class CamaroteService
    {
        private static CamaroteRepository camaroteRepository = new CamaroteRepository();

        internal Camarote GetByPrimaryKey(int idNavio, int numCubierta, int numCamarote)
        {
            return camaroteRepository.GetByPrimaryKey(idNavio, numCubierta, numCamarote);
        }

        internal Camarote GetById(int id)
        {
            return camaroteRepository.GetById(id);
            
        }

        internal List<Camarote> GetAll()
        {
            return camaroteRepository.GetAll();
        }


        internal void CrearCamarote(Camarote camarote)
        {
            camaroteRepository.Create(camarote);
        }

        internal void ModificarCamarote(Camarote camarote)
        {
            camaroteRepository.Update(camarote);
        }

        internal void DeleteById(int id)
        {
           camaroteRepository.DeleteById(id);
        }
    }
}
