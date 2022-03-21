using Domain;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLConnection
{
    public class SQLAuthorRepository : SQLGenericRepository<Author, ApplicationContext>, IAuthorRepository
    {
        public int GetById()
        {
            throw new NotImplementedException();
        }
    }
}
