using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class Data : IData
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book> { new Book { Id = 1, Name = "TD", Price = 100 }, new Book { Id = 2, Name = "FM", Price = 200 } };
        }
    }
}
