using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Entities
{
    public class Authors : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public ICollection<Books> Books { get; set; } = null!;
    }
}
