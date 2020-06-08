using ProyectoPAV.entidades;
using ProyectoPAV.negocio.repository;
using ProyectoPAV.negocio.repository.tipoCamarote_repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.servicios
{
    public class TipoCamaroteService
    {
       
        private static TipoCamaroteRepository tipoCamaroteRepository = new TipoCamaroteRepository();

        internal TipoCamarote GetById(int id)
        {
            return tipoCamaroteRepository.GetById(id);
        }

        internal List<TipoCamarote> GetAll()
        {
            return tipoCamaroteRepository.GetAll();
        }

        internal List<TipoCamarote> GetByName(string name)
        {
            return tipoCamaroteRepository.GetByName(name);
        }

        internal void CreateTipoCamarote(TipoCamarote tipoCamarote)
        {
            tipoCamaroteRepository.Create(tipoCamarote);
        }

        internal void DeleteTipoCamaroteById(int id)
        {
            tipoCamaroteRepository.DeleteById(id);
        }

    }
}
