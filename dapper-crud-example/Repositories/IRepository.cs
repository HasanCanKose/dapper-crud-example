using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dapper_crud_example.Repositories
{
    public interface IRepository<T>
    {
        void Add(T t);
        List<T> GetAll();
        T GetById(int id);
        void Delete(int id);
        void Update(T t);
    
    }
}
