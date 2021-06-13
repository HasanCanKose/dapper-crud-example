using dapper_crud_example.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dapper_crud_example.Repositories
{
    public class BookRepository : IRepository<Book>
    {

        private string connectionString;
        private IConfiguration configuration;

        public BookRepository()
        {
            connectionString = configuration.GetConnectionString("db");
        }
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
