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
    public class TipoCamaroteService
    {
        private static TipoCamaroteDao tipoCamaroteDao;

        public TipoCamaroteService()
        {
            tipoCamaroteDao = new TipoCamaroteDao();
        }


        internal TipoCamarote getById(int id)
        {
            return tipoCamaroteDao.getById(id);
        }

        internal DataTable consultarPorNombre(string nombre)
        {
            return tipoCamaroteDao.consultar_x_nombre(nombre);
        }

        internal DataTable consultarTodos()
        {
            return tipoCamaroteDao.consultarTodos();
        }

        internal void crearTipoCamarote(TipoCamarote tipoCamarote)
        {
            tipoCamaroteDao.create(tipoCamarote);
        }

        //internal bool modificarNavio(Navio navio)
        //{
        //    return navioDao.update(navio);
        //}

        //internal bool eliminarNavio(int id)
        //{
        //    return navioDao.delete(id);
        //}

    }
}
