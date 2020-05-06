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
    class TipoClasificacionNavioService
    {
        private static TipoClasificacionNavioDao clasificacionNavioDao;

        public TipoClasificacionNavioService()
        {
            clasificacionNavioDao = new TipoClasificacionNavioDao();
        }

        internal DataTable consultarPorNombre(string nombre)
        {
            return clasificacionNavioDao.consultar_x_nombre(nombre);
        }

        internal DataTable consultarTodos()
        {
            return clasificacionNavioDao.consultarTodos();
        }

        internal bool crearTipoClasificacionNavio(TipoClasificacionNavio tipoClasificacion)
        {
            return clasificacionNavioDao.create(tipoClasificacion);
        }

        internal bool modificarTipoClasificacionNavio(TipoClasificacionNavio tipoClasificacion)
        {
            return clasificacionNavioDao.update(tipoClasificacion);
        }

        internal bool eliminarTipoClasificacionNavio(TipoClasificacionNavio tipoClasificacion)
        {
            return clasificacionNavioDao.delete(tipoClasificacion);
        }




    }
}
