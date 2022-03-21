using Domain;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBookService
    {
        public Book Create(Book book);
        public BookViewModel GetBookById(int id);
    }
}
