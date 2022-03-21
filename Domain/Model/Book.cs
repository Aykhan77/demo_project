using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Book : BaseEntity
    {
        public Book()
        {

        }

        public Book(string a)
        {

        }

        [MaxLength(20)]
        public string Author { get; set; }
    }
}
