using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay2CSharpAdvanced
{
    internal class BookFunctions
    {

        public static string GetTitle(Book book)
        {
            return book.Title;
        }

        public static string GetAuthors(Book book)
        {
            return string.Join(", " ,book.Authors);
        }

        public static string GetPrice(Book book) => book.Price.ToString("C"); // Lambda Expression
    }
}
