using Business.Concrete;
using Domain;
using Domain.Repositories;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLConnection
{
    public class SQLBookRepository : SQLGenericRepository<Book, ApplicationContext>, IBookRepository
    {
        public Book GetBookById(int id)
        {
            using (var context = new ApplicationContext())
            {
                var _book = context.Books.Find(id);

                return _book;
            }
        }
    }
}
