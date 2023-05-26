using Books_Shop_Management_System_DAL.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Fluent_Validation
{
    public class AuthorsValidation : AbstractValidator<Authors>
    {
        public AuthorsValidation()
        {
            RuleFor(x => x.FirstName).NotNull().MaximumLength(255);

            RuleFor(x => x.LastName).NotNull().MaximumLength(255);
        }
    }
}
