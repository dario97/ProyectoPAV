using ProyectoPAV.entidades;
using ProyectoPAV.negocio.repository;
using ProyectoPAV.negocio.repository.tipoNavio_repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.servicios
{
    public class TipoClasificacionNavioService
    {
     
        private static TipoNavioRepository tipoNavioRepository = new TipoNavioRepository();

        internal List<TipoClasificacionNavio> GetByName(string name)
        {
            return tipoNavioRepository.GetByName(name);
        }

        internal List<TipoClasificacionNavio> GetAll()
        {
            return tipoNavioRepository.GetAll();
        }

        internal void CreateTipoNavio(TipoClasificacionNavio tipoNavio)
        {
            tipoNavioRepository.Create(tipoNavio);
        }

        internal void UpdateTipoNavio(TipoClasificacionNavio tipoNavio)
        {
            tipoNavioRepository.Update(tipoNavio);
        }

        internal void DeleteTipoNavioById(int id) 
        {
            try
            {
                tipoNavioRepository.DeleteById(id);
            }
            catch (OleDbException e)
            {
                throw e;
            }
            
        }




    }
}
