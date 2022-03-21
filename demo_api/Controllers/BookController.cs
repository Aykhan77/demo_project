using Business.Abstract;
using Business.Concrete;
using Business.Mapper;
using Domain;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;
using SQLConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace demo_api.Controllers
{
    [ApiController]
    [Route("api/book")]
    public class BookController : Controller
    {
        private IBookService _bookservice;
        public BookController(IBookService bookservice)
        {
            _bookservice = bookservice;
        }

        [HttpGet("getstring")]
        public string GetString()
        {
            return "test string from api controller";
        }

        //[HttpPost("create")]
        //public Book CreateBook([FromBody] Book book)
        //{
        //    //SQLBookRepository repository = new SQLBookRepository();

        //    //_bookRepository.Create(book.Name, book.Author);



        //    return "book created successfully";
        //}

        [HttpGet("getbook/{id}")]
        public BookViewModel GetBookById(int id)
        {
            return _bookservice.GetBookById(id);
        }
    }
}
