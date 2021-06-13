using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dapper_crud_example.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Plot { get; set; }
        public string Author { get; set; }
    }
}
