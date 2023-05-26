using Books_Shop_Management_System_DAL.Entities;
using Books_Shop_Management_System_DTO.Data_transfer_objects.Response_Result_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_BLL.Services.Interfaces
{
    public interface IBooksServices
    {
        Task<ResultResponse<IEnumerable<GetBooksResultDTO>>> GetBooksByAgeRestricitonAsync(string ageRestriction);

        Task<ResultResponse<IEnumerable<GetGoldenBooksResultDTO>>> GetGoldenBooksAsync();

        Task<ResultResponse<IEnumerable<GetBooksByPriceResultDTO>>> GetBooksByPriceAsync();
    }
}
