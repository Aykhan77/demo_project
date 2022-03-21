using Business.Abstract;
using Business.Mapper;
using Domain;
using Domain.Repositories;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BookService : IBookService
    {
        private IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public Book Create(Book book)
        {
            throw new NotImplementedException();
        }

        public BookViewModel GetBookById(int id)
        {
            BookMapper mapper = new BookMapper();

            return mapper.BookToBl(_repository.GetBookById(id));
        }
    }
}
