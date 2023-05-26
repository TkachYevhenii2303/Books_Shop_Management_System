using Books_Shop_Management_System_DAL.Contex;
using Books_Shop_Management_System_DAL.Repositories;
using Books_Shop_Management_System_DAL.Repositories.Interfaces;
using Books_Shop_Management_System_DAL.Unit_of_Work_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_DAL.Unit_of_Work_Pattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BooksContext _context;

        public IBooksRepository BooksRepository { get; private set; }
        
        public UnitOfWork(BooksContext context)
        {
            _context = context;

            BooksRepository = new BooksRepository(context);
        }

        public async void Dispose() => await _context.DisposeAsync();
    }
}
