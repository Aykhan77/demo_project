using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLConnection
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors{ get; set; }

        public ApplicationContext()
        {

        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost; Initial Catalog=demodb; User ID=khazar;Password=ayxan1;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
