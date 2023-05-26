using Books_Shop_Management_System_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Contex.Configurations
{
    public class BooksConfigurations : IEntityTypeConfiguration<Books>
    {
        public void Configure(EntityTypeBuilder<Books> builder)
        {
            builder
                .HasMany<BooksCategories>(x => x.BooksCategories)
                .WithOne(x => x.Books)
                .HasForeignKey(x => x.BooksID)
                .IsRequired().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
