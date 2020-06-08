using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAV.negocio.repository
{
   public interface IRepository<T, K>
    {
        T Mapping(DataRow row);

       List<T> GetAll();
        T GetById(K id);

        void Create(T obj);

        void Update(T obj);

        void DeleteById(K id);
    }
}
