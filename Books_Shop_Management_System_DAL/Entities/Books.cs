using Books_Shop_Management_System_DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Entities
{
    public class Books : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Decimal Price { get; set; } 

        public int Copies { get; set; }

        public RestrictionType AgeRestriction { get; set; } = RestrictionType.Teen;

        public DateTime ReleaseDate { get; set; }

        public EditionType EditionType { get; set; } = EditionType.Traditional;

        public Authors Authors { get; set; } = null!;

        public Guid AuthorsID { get; set; }

        public ICollection<BooksCategories> BooksCategories { get; set; } = null!;
    }
}
