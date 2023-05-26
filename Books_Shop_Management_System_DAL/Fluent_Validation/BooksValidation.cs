using Books_Shop_Management_System_DAL.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Fluent_Validation
{
    public class BooksValidation : AbstractValidator<Books>
    {
        public BooksValidation()
        {
            RuleFor(x => x.Title).NotNull().MaximumLength(255);
           
            RuleFor(x => x.Description).NotNull().MaximumLength(255);

            RuleFor(x => x.Price).NotNull();

            RuleFor(x => x.Copies).NotNull().InclusiveBetween(1, 1000);
        }
    }
}
