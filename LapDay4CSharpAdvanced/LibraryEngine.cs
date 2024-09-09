using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay4CSharpAdvanced
{
    internal class LibraryEngine
    {
        public static void processBooks(List<Book> books , Func<Book , string> fptr)
        {
            foreach (Book item in books)
            {
                Console.WriteLine(fptr(item));
            }
        }


        #region  User Defined Delegate Datatype
        public static void processBooks(List<Book> books, BookFuncDelegateDataType fptr)
        {
            foreach (Book item in books)
            {
                Console.WriteLine(fptr(item));
            }
        } 
        #endregion
    }
}
