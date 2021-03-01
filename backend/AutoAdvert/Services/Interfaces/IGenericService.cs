using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoAdvert.Service.Interfaces
{
    public interface IGenericService<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        void Insert(T obj);
        void Update(T obj);
        Task Delete(int id);
    }
}
