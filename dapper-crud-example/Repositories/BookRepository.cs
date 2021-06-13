using dapper_crud_example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dapper_crud_example.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        public void Add(Book t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Book t)
        {
            throw new NotImplementedException();
        }
    }
}
