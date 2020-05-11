using ProyectoPAV.entidades;
using ProyectoPAV.negocio.repository;
using System.Collections.Generic;
using System.Data;

namespace ProyectoPAV.negocio.servicios
{
    public class CamaroteService
    {
        private static CamaroteDao camaroteDao = new CamaroteDao();

        //internal DataTable consultarPorNombre(string nombre)
        //{
        //    //return camaroteDao.consultarCamarote(nombre);
        ////}

        internal Camarote consultarCamarote(int codNavio, int numCubierta, int numCamarote)
        {
            return camaroteDao.consultarCamarote(codNavio, numCubierta, numCamarote);
        }

        internal Camarote getById(int id)
        {
            return camaroteDao.getById(id);
        }

        internal List<Camarote> getAll()
        {
            return camaroteDao.getAll();
        }

        internal DataTable consultarTodos()
        {
            return camaroteDao.consultarTodos();
        }

        internal bool crearCamarote(Camarote camarote)
        {
            return camaroteDao.create(camarote);
        }

        internal bool modificarNavio(Camarote camarote)
        {
            return camaroteDao.update(camarote);
        }

        //internal bool eliminarNavio(int id)
        //{
        //    //return camaroteDao.delete(id);
        //}
    }
}
