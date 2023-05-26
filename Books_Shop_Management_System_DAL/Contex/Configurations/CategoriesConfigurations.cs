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
    public class CategoriesConfigurations : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder
                .HasMany<BooksCategories>(x => x.BooksCategories)
                .WithOne(x => x.Categories)
                .HasForeignKey(x => x.CategoriesID)
                .IsRequired().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
