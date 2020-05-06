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

        internal DataTable consultarCamarote(string caca, string d, string dsad)
        {
            return camaroteDao.consultarTodos();
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
