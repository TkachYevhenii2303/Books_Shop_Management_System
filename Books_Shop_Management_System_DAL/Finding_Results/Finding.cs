using Books_Shop_Management_System_DAL.Contex;
using Books_Shop_Management_System_DAL.Entities;
using Books_Shop_Management_System_DAL.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Globalization;
using Microsoft.AspNetCore.Http;

namespace Books_Shop_Management_System_DAL.Finding_Results
{
    public class Finding
    {
        private readonly DbContextOptions<BooksContext> _options;

        private readonly BooksContext _context;

        private readonly IConfiguration _configuration;

        public Finding()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            _options = new DbContextOptionsBuilder<BooksContext>()
                .UseSqlServer(_configuration.GetConnectionString("DefaultConnection")).Options;

            _context = new BooksContext(_options);
        }

        public async Task<string> GetBooksByAgeRestricitonAsync(string ageRestriction)
        {
            var result = await _context.Set<Books>()
                .Where(x => x.AgeRestriction == GetRestrictionType(ageRestriction)).OrderBy(x => x.Title)
                .Select(x => $"The title: {x.Title} \nThe description:  {x.Description} \nThe age restriction: {x.AgeRestriction} \n\n" )
                .AsNoTracking().ToListAsync();

            return Result<KeyNotFoundException>(result, "The element in a collection does not match any key in the collection.");
        }

        private static RestrictionType GetRestrictionType(string ageRestriction)
        {
            if (!Enum.TryParse<RestrictionType>(ageRestriction.ToLower(), true, out var specialty))
            {
                throw new ArgumentException($"Invalid the specialty books: {ageRestriction}");
            }

            return specialty;
        }

        public async Task<string> GetGoldenBooksAsync() 
        {
            var result = await _context.Set<Books>()
                .Where(x => x.EditionType == EditionType.Traditional && x.Copies < 500)
                .Select(x => $"The title: {x.Title} \nThe edition type:  {x.EditionType} \nThe number of copies: {x.Copies} \n\n")
                .AsNoTracking().ToListAsync();

            return Result<KeyNotFoundException>(result, "The element in a collection does not match any key in the collection.");
        }

        public async Task<string> GetBooksByPriceAsync()
        {
            var result = await _context.Set<Books>()
                .Where(x => x.Price >= 40).OrderByDescending(book => book.Price)
                .Select(x => $"The title: {x.Title} \nThe price:  {x.Price}$\n\n")
                .AsNoTracking().ToListAsync();

            return Result<KeyNotFoundException>(result, "The element in a collection does not match any key in the collection.");
        }

        public async Task<string> GetBooksNotRealeasedAsync(int year) 
        {
            var result = await _context.Set<Books>()
                .Where(x => x.ReleaseDate.Year != year)
                .Select(x => $"The title: {x.Title} \nThe release dateString:  {x.ReleaseDate}$\n\n")
                .AsNoTracking().ToListAsync();

            return Result<KeyNotFoundException>(result, "The element in a collection does not match any key in the collection.");
        }

        public async Task<string> GetBooksByCategoryAsync(string categories)
        {
            var collection = categories.ToLower().Split(" ");

            var books = await _context.Set<Books>()
               .Where(book => book.BooksCategories.Any(bookCategories => collection.Contains(bookCategories.Categories.Title)))
               .Select(x => new { BooksTitle = x.Title, Categories = x.BooksCategories.Select(b => b.Categories.Title).ToList() })
               .AsNoTracking().ToListAsync();

            List<string> result = books.SelectMany(x => x.Categories
                .Select(category => $"{x.BooksTitle}, {category}"))
                .ToList();

            return Result<KeyNotFoundException>(result, "The element in a collection does not match any key in the collection.");
        }

        public async Task<string> GetBookReleasedBeforeAsync(string dateString)
        {
            DateTime dateTimeInvariant = DateTime.ParseExact(dateString, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var result = await _context.Set<Books>()
                .Where(x => x.ReleaseDate < dateTimeInvariant)
                .Select(x => $"The title: {x.Title} \nThe edition type: {x.EditionType} \nThe price: {x.Price} \n The release date:  {x.ReleaseDate}$\n\n")
                .AsNoTracking().ToListAsync();

            return Result<KeyNotFoundException>(result, "The element in a collection does not match any key in the collection.");
        }

        public async Task<string> GetAuthorNamesEnglishInAsync(string lastCharacters)
        {
            var result = await _context.Set<Authors>()
              .Where(author => author.FirstName.EndsWith(lastCharacters)).OrderBy(author => author.FirstName)
              .Select(author => author.FirstName + " " + author.LastName)
              .AsNoTracking().ToListAsync();

            return Result<KeyNotFoundException>(result, "The element in a collection does not match any key in the collection.");
        }

        public async Task<string> GetBookTitlesContainingAsync(string input)
        {
            var result = await _context.Set<Books>()
               .Where(book => book.Title.ToLower().Contains(input.ToLower()))
               .Select(book => book.Title).Distinct()
               .AsNoTracking().ToListAsync();

            return Result<KeyNotFoundException>(result, "The element in a collection does not match any key in the collection.");
        }

        public async Task<string> GetBookByAuthorAsync(string input)
        {
            var authorsAndBooks = await _context.Set<Authors>()
               .Where(author => author.LastName.ToLower().Contains(input.ToLower()))
               .Select(x => new { FirstName = x.FirstName, LastName = x.LastName, BooksTitle = x.Books.Select(b => b.Title).ToList() })
               .AsNoTracking().ToListAsync();


            List<string> result = authorsAndBooks.SelectMany(x => x.BooksTitle
                .Select(book => $"{book}, {x.FirstName} {x.LastName}"))
                .ToList();

            return Result<KeyNotFoundException>(result, "The element in a collection does not match any key in the collection.");
        }

        public async Task<string> IncreasePricesAsync(string dateString)
        {
            DateTime dateTimeInvariant = DateTime.ParseExact(dateString, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books = await _context.Set<Books>()
                .Where(x => x.ReleaseDate > dateTimeInvariant)
                .ToListAsync();

            foreach (var book in books)
            {
                book.Price += 5;
            }

            await _context.SaveChangesAsync();

            var result = books.Select(x => $"The title: {x.Title}\n The price: {x.Price}\n The release date: {x.ReleaseDate.ToString("dd-MM-yyyy")}\n\n").ToList();

            return Result<KeyNotFoundException>(result, "The element in a collection does not match any key in the collection.");
        }

        private string Result<TException>(List<string> result, string exceptionMessage)
            where TException : Exception
        {
            if (result.Count == 0)
                throw (TException)Activator.CreateInstance(typeof(TException), exceptionMessage)!;

            return string.Join(Environment.NewLine, result);
        }
    }
}
