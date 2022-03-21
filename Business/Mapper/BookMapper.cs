using Domain;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mapper
{
    public class BookMapper
    {
        public BookViewModel BookToBl(Book book)
        {
            BookViewModel model = new BookViewModel();
            model.Name = book.Name;
            model.Author = book.Author;

            return model;
        }
    }
}
