using Books_Shop_Management_System_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Contex.Configurations
{
    public class AuthorsConfigurations : IEntityTypeConfiguration<Authors>
    {
        public void Configure(EntityTypeBuilder<Authors> builder)
        {
            builder
                .HasMany<Books>(x => x.Books)
                .WithOne(x => x.Authors)
                .HasForeignKey(x => x.AuthorsID)
                .IsRequired().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
