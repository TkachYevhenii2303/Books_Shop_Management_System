using Books_Shop_Management_System_DAL.Bogus;
using Books_Shop_Management_System_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Contex
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) : base(options) { }

        public DbSet<Authors> Authors { get; set; } 

        public DbSet<Books> Books { get; set; }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<BooksCategories> BooksCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            var seedingWithBogus = new SeedingWithBogus();

            modelBuilder.Entity<Authors>().HasData(seedingWithBogus.Authors);

            modelBuilder.Entity<Books>().HasData(seedingWithBogus.Books);

            modelBuilder.Entity<Categories>().HasData(seedingWithBogus.Categories);

            modelBuilder.Entity<BooksCategories>().HasData(seedingWithBogus.BooksCategories);
        }
    }
}
