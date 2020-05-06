using ProyectoPAV.entidades;
using ProyectoPAV.negocio.repository;
using System.Data;

namespace ProyectoPAV.negocio.servicios
{
    class CamaroteService
    {
        private static CamaroteDao camaroteDao = new CamaroteDao();

        //internal DataTable consultarPorNombre(string nombre)
        //{
        //    //return camaroteDao.consultarCamarote(nombre);
        ////}

        internal DataTable consultarTodos()
        {
            return camaroteDao.consultarTodos();
        }

        internal bool crearNavio(Camarote camarote)
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
