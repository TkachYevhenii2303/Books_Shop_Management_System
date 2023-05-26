using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Entities
{
    public class BooksCategories : BaseEntity
    {
        public Books Books { get; set; } = null!;

        public Guid BooksID { get; set; }

        public Categories Categories { get; set; } = null!;

        public Guid CategoriesID { get; set; }
    }
}
