using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IData
    {
        IEnumerable<Book> GetBooks();
    }
}
