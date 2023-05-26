using Books_Shop_Management_System_DAL.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Fluent_Validation
{
    public class CategoriesValidation : AbstractValidator<Categories>
    {
        public CategoriesValidation()
        {
            RuleFor(x => x.Title).NotEmpty().NotNull().Length(5, 255);
        }
    }
}
