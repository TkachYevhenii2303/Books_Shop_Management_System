using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Entities
{
    public class Categories : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public ICollection<BooksCategories> BooksCategories { get; set; } = null!;
    }
}
