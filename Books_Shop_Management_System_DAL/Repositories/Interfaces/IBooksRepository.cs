using Books_Shop_Management_System_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Repositories.Interfaces
{
    public interface IBooksRepository
    {
        Task<ResultResponse<IEnumerable<Books>>> GetBooksByAgeRestricitonAsync(string ageRestriction);

        Task<ResultResponse<IEnumerable<Books>>> GetGoldenBooksAsync();

        Task<ResultResponse<IEnumerable<Books>>> GetBooksByPriceAsync();
    }
}
