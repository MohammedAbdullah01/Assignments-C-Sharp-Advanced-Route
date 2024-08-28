using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay2CSharpAdvanced
{
    delegate string DelegateMethodBook(Book book);
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bookList, DelegateMethodBook del)
        {
            foreach (Book book in bookList)
            {
                Console.WriteLine(del(book));
            }
        }

        public static void ProcessBooks2(List<Book> bookList, Func<Book , string> del)
        {
            foreach (Book book in bookList)
            {
                Console.WriteLine(del(book));
            }
        }
    }
}
