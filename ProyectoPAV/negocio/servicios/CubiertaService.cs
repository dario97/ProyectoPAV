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
    class CubiertaService
    {
        private static CubiertaDao cubiertaDao;

        public CubiertaService()
        {
            cubiertaDao = new CubiertaDao();
        }


        internal Cubierta getById(int id)
        {
            return cubiertaDao.getById(id);
        }

        internal List<Cubierta> getAll()
        {
            return cubiertaDao.getAll();
        }

        internal DataTable consultarPorNombre(string nombre)
        {
            return cubiertaDao.consultar_x_nombre(nombre);
        }

        //internal DataTable consultarTodos()
        //{
        //    return tipoCamaroteDao.consultarTodos();
        //}

        internal void crearCubierta(Cubierta cubierta)
        {
            cubiertaDao.create(cubierta);
        }

        //internal bool modificarNavio(Navio navio)
        //{
        //    return navioDao.update(navio);
        //}

        internal bool eliminar(int id)
        {
            return cubiertaDao.delete(id);
        }
    }
}
