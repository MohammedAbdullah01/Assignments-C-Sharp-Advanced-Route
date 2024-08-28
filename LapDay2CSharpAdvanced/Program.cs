namespace LapDay2CSharpAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List OF Books
            //List<Book> books = new List<Book>
            //{
            //    new Book("1" ,"C#" , new []{ "Mohamed", "Ahmed" , "Rayyan"} ,DateTime.Now , 20),
            //    new Book("2" ,"C# OOP" , new []{ "Mohamed", "Ahmed" , "Noah"} ,DateTime.Now , 60),
            //    new Book("3" ,"C# LINQ" , new []{ "Mohamed", "Ahmed" , "Osama"} ,DateTime.Now , 80),
            //}; 
            #endregion

            #region Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
            //DelegateMethodBook 
            //    title = BookFunctions.GetTitle,
            //    authors = BookFunctions.GetAuthors,
            //    price = BookFunctions.GetPrice;

            //LibraryEngine.ProcessBooks(books, title);
            //LibraryEngine.ProcessBooks(books, authors);
            //LibraryEngine.ProcessBooks(books, price); 
            #endregion


            #region Use the Proper build in delegate. 
            //Func<Book , string>
            //    funcTitle = BookFunctions.GetTitle,
            //    funcAuthors = BookFunctions.GetAuthors,
            //    funcPrice = BookFunctions.GetPrice;

            //LibraryEngine.ProcessBooks2(books, funcTitle);
            //LibraryEngine.ProcessBooks2(books, funcAuthors);
            //LibraryEngine.ProcessBooks2(books, funcPrice); 
            #endregion


            #region Anonymous Method (GetISBN).
            //LibraryEngine.ProcessBooks2(books, delegate (Book book) { return book.ISBN; });
            #endregion


            #region Lambda Expression (GetPublicationDate).
            //LibraryEngine.ProcessBooks2(books, b => b.PublicationDate.ToString()); 
            #endregion

        }
    }
}
