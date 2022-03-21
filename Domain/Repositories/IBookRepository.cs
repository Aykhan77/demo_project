using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface IBookRepository
    {
        public Book Create(Book book);
        public Book GetBookById(int id);
    }
}
