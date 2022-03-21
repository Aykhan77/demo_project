using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLConnection
{
    public abstract class SQLGenericRepository<TEntity, MyContext>
         where TEntity : class
         where MyContext : DbContext, new()
    {
        public TEntity Create(TEntity entity)
        {
            using (var context = new MyContext())
            {
                context.Set<TEntity>().Add(entity);

                context.SaveChanges();
            }

            return entity;
        }

        public TEntity Delete(int id)
        {
            using (var context = new MyContext())
            {
                var en = context.Set<TEntity>().Find(id);

                context.Set<TEntity>().Remove(en);

                return en;

            }
        }
    }
}
