using Books_Shop_Management_System_DAL.Contex;
using Books_Shop_Management_System_DAL.Finding_Results;
using Microsoft.EntityFrameworkCore;

namespace Books_Shop_Management_System_Console
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            Finding Finding = new Finding();

            //await Console.Out.WriteLineAsync($"The result of task 1: \n {await Finding.GetBooksByAgeRestricitonAsync(Console.ReadLine()!)}");

            //await Console.Out.WriteLineAsync($"The result of task 2: \n {await Finding.GetGoldenBooksAsync()}");

            //await Console.Out.WriteLineAsync($"The result of task 3: \n {await Finding.GetBooksByPriceAsync()}");

            //await Console.Out.WriteLineAsync($"The result of task 4: \n {await Finding.GetBooksNotRealeasedAsync(Convert.ToInt32(Console.ReadLine()!))}");

            //await Console.Out.WriteLineAsync($"The result of task 5: \n {await Finding.GetBooksByCategoryAsync(Console.ReadLine()!)}");

            //await Console.Out.WriteLineAsync($"The result of task 6: \n {await Finding.GetBookReleasedBeforeAsync(Console.ReadLine()!)}");

            //await Console.Out.WriteLineAsync($"The result of task 7: \n {await Finding.GetAuthorNamesEnglishInAsync(Console.ReadLine()!)}");

            //await Console.Out.WriteLineAsync($"The result of task 8: \n {await Finding.GetBookTitlesContainingAsync(Console.ReadLine()!)}");

            //await Console.Out.WriteLineAsync($"The result of task 9: \n {await Finding.GetBookByAuthorAsync(Console.ReadLine()!)}");

            //await Console.Out.WriteLineAsync($"The result of task 10: \n {await Finding.IncreasePricesAsync(Console.ReadLine()!)}");

            Console.ReadLine();
        }
    }
}