using Books_Shop_Management_System_DAL.Contex;
using Books_Shop_Management_System_DAL.Entities;
using Books_Shop_Management_System_DAL.Enums;
using Books_Shop_Management_System_DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Repositories
{
    public class BooksRepository : IBooksRepository
    {
        private readonly BooksContext _context;

        public BooksRepository(BooksContext context)
        {
            _context = context;
        }

        public async Task<ResultResponse<IEnumerable<Books>>> GetBooksByAgeRestricitonAsync(string ageRestriction)
        {
            var resultResponse = new ResultResponse<IEnumerable<Books>>();

            resultResponse.Result = await _context.Set<Books>()
                .Where(x => x.AgeRestriction == ReturnRestrinctionTypeUsingString(ageRestriction.ToLower()))
                .AsNoTracking().ToListAsync();

            resultResponse.Message = "Returning all Books by age restriction type!!!";

            return resultResponse;
        }

        private static RestrictionType ReturnRestrinctionTypeUsingString(string ageRestriction)
        {
            if (!Enum.TryParse<RestrictionType>(ageRestriction, true, out var result))
            {
                throw new ArgumentException($"Invalid the age restrinction result: {ageRestriction}!!!");
            }

            return result;
        }

        public async Task<ResultResponse<IEnumerable<Books>>> GetGoldenBooksAsync()
        {
            var resultResponse = new ResultResponse<IEnumerable<Books>>();

            resultResponse.Result = await _context.Set<Books>()
                .Where(x => x.EditionType == EditionType.PopularMagazines && x.Copies < 500)
                .AsNoTracking().ToListAsync();

            resultResponse.Message = "Returning all Books by edition type and number of copies!!!";

            return resultResponse;
        }

        public async Task<ResultResponse<IEnumerable<Books>>> GetBooksByPriceAsync()
        {
            var resultResponse = new ResultResponse<IEnumerable<Books>>();

            resultResponse.Result = await _context.Set<Books>()
                .Where(x => x.Price > 40).OrderByDescending(x => x.Price)
                .AsNoTracking().ToListAsync();

            resultResponse.Message = "Returning all Books by prices that more than 40$!!!";

            return resultResponse;
        }

        public async Task<ResultResponse<IEnumerable<Books>>> GetBooksNotRealeasedAsync(int year)
        {
            var resultResponse = new ResultResponse<IEnumerable<Books>>();

            resultResponse.Result = await _context.Set<Books>()
                .Where(x => x.ReleaseDate.Year != year)
                .AsNoTracking().ToListAsync();

            resultResponse.Message = "Returning all Books by not given year!!!";

            return resultResponse;
        }
    }
}
