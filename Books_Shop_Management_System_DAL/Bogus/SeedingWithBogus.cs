using Bogus;
using Books_Shop_Management_System_DAL.Entities;
using Books_Shop_Management_System_DAL.Enums;
using Books_Shop_Management_System_DAL.Fluent_Validation;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Bogus
{
    public class SeedingWithBogus
    {
        public IReadOnlyCollection<Authors> Authors { get; set; } = new List<Authors>();
        public IReadOnlyCollection<Books> Books { get; set; } = new List<Books>();  
        public IReadOnlyCollection<Categories> Categories { get; set; } = new List<Categories>();
        public IReadOnlyCollection<BooksCategories> BooksCategories { get; set; } = new List<BooksCategories>();

        public const int AUTHORS = 75;
        public const int BOOKS = 200;
        public const int CATEGORIES = 50;
        public const int BOOKS_CATEGORIES = 150;

        public SeedingWithBogus()
        {
            Authors = SeedingAuthors(AUTHORS);
            Books = SeedingBooks(BOOKS, Authors);
            Categories = SeedingCategories(CATEGORIES);
            BooksCategories = SeedingBooksCategories(BOOKS_CATEGORIES, Books, Categories);
        }

        private static IReadOnlyCollection<Authors> SeedingAuthors(int size)
        {
            var authorsValidator = new AuthorsValidation();
            
            var collection = new Faker<Authors>()
                .RuleFor(x => x.FirstName, f => f.Person.FirstName)
                .RuleFor(x => x.LastName, f => f.Person.LastName)
                .Generate(size);

            var validationErrors = new List<ValidationFailure>();

            foreach (var item in collection)
            {
                var validationResult = authorsValidator.Validate(item);

                if (!validationResult.IsValid)
                {
                    validationErrors.AddRange(validationResult.Errors);
                }
            }

            if (validationErrors.Count > 0)
            {
                throw new Exception("Something went wrong while validation...");
            }

            return collection;
        }

        private static IReadOnlyCollection<Books> SeedingBooks(int size, IEnumerable<Authors> authors)
        {
            var booksValidator = new BooksValidation(); 

            var collection = new Faker<Books>()
                .RuleFor(x => x.Title, f => f.Commerce.Product())
                .RuleFor(x => x.Description, f => f.Commerce.ProductDescription())
                .RuleFor(x => x.Price, f => f.Finance.Amount())
                .RuleFor(x => x.Copies, f => f.Random.Int(10, 1000))
                .RuleFor(x => x.AgeRestriction, f => f.PickRandom<RestrictionType>())
                .RuleFor(x => x.ReleaseDate, f => f.Date.Future())
                .RuleFor(x => x.EditionType, f => f.PickRandom<EditionType>())
                .RuleFor(x => x.AuthorsID, f => f.PickRandom(authors).ID)
                .Generate(size);

            var errorsCount = ValidationErrorsCount(booksValidator, collection);

            if (errorsCount > 0)
            {
                throw new Exception($"Something went wrong while validation in method {typeof(SeedingWithBogus).FullName}");
            }

            return collection;
        }

        private static IReadOnlyCollection<Categories> SeedingCategories(int size)
        {
            var categoriesValidation = new CategoriesValidation();

            var collection = new Faker<Categories>()
                .RuleFor(x => x.Title, f => f.PickRandom<CategoriesType>().ToString())
                .Generate(size);

            var errorsCount = ValidationErrorsCount(categoriesValidation, collection);

            if (errorsCount > 0)
            {
                throw new Exception($"Something went wrong while validation in method {typeof(SeedingWithBogus).FullName}");
            }

            return collection;
        }

        private static IReadOnlyCollection<BooksCategories> SeedingBooksCategories(int size, IEnumerable<Books> books, IEnumerable<Categories> categories)
        {
            var collection = new Faker<BooksCategories>()
                .RuleFor(x => x.BooksID, f => f.PickRandom(books).ID)
                .RuleFor(x => x.CategoriesID, f => f.PickRandom(categories).ID)
                .Generate(size);

            return collection;
        }

        private static int ValidationErrorsCount<TEntity>(AbstractValidator<TEntity> validationRules, IEnumerable<TEntity> collection)
        {
            var validationErrors = new List<ValidationFailure>();

            foreach (var item in collection)
            {
                var validationResult = validationRules.Validate(item);

                if (!validationResult.IsValid)
                {
                    validationErrors.AddRange(validationResult.Errors);
                }
            }

            return validationErrors.Count;
        }
    }
}
