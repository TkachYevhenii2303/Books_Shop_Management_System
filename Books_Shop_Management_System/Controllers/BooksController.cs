using Books_Shop_Management_System_BLL.Services.Interfaces;
using Books_Shop_Management_System_DAL.Entities;
using Books_Shop_Management_System_DTO.Data_transfer_objects.Response_Result_DTO;
using Microsoft.AspNetCore.Mvc;

namespace Books_Shop_Management_System.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksServices _booksServices;

        public BooksController(IBooksServices booksServices)
        {
            _booksServices = booksServices;
        }

        [HttpGet, Route("Return_books_age_Restriction")]
        public async Task<ActionResult<ResultResponse<IEnumerable<GetBooksResultDTO>>>> GetBooksByAgeRestricitonAsync(string ageRestriction)
        {
            var result = await _booksServices.GetBooksByAgeRestricitonAsync(ageRestriction);

            if (result is null)
            {
                throw new ArgumentNullException($"Something went wrong... Location is {typeof(BooksController)}");
            }

            return Ok(result);
        }

        [HttpGet, Route("Return_books_by_Edition_type_and_Copies")]
        public async Task<ActionResult<ResultResponse<IEnumerable<GetGoldenBooksResultDTO>>>> GetGoldenBooksAsync()
        {
            var result = await _booksServices.GetGoldenBooksAsync();

            if (result is null)
            {
                throw new ArgumentNullException($"Something went wrong... Location is {typeof(BooksController)}");
            }

            return Ok(result);
        }

        [HttpGet, Route("Return_books_by_Price")]
        public async Task<ActionResult<ResultResponse<IEnumerable<GetBooksByPriceResultDTO>>>> GetBooksByPriceAsync()
        {
            var result = await _booksServices.GetBooksByPriceAsync();

            if (result is null)
            {
                throw new ArgumentNullException($"Something went wrong... Location is {typeof(BooksController)}");
            }

            return Ok(result);
        }
    }
}
