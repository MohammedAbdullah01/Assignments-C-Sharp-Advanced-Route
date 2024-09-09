namespace LapDay4CSharpAdvanced
{

    public delegate string BookFuncDelegateDataType(Book book);
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book("102030" , "C#" , new string[] { "Mohamed Ahmed1","Noor Mohamed1","Rayyan Ahmed1"} ,DateTime.Now , 150.50M));
            books.Add(new Book("405060" , "PHP" , new string[] { "Mohamed Ahmed2","Noor Mohamed2","Rayyan Ahmed2"} ,DateTime.Now , 200.50M));
            books.Add(new Book("708090" , "Java" , new string[] { "Mohamed Ahmed3","Noor Mohamed3","Rayyan Ahmed3"} ,DateTime.Now , 250.50M));
            books.Add(new Book("100110" , "Python" , new string[] { "Mohamed Ahmed4","Noor Mohamed4","Rayyan Ahmed4"} ,DateTime.Now , 300.50M));



            #region  User Defined Delegate Datatype

            //BookFuncDelegateDataType fptr = BookFunctions.GetTitle;
            //fptr = BookFunctions.GetAuthors;
            //fptr = BookFunctions.GetPrice;

            //LibraryEngine.processBooks(books, fptr);

            #endregion


            #region BCL Delegates
            //Func<Book, string> fptr = BookFunctions.GetTitle;

            //fptr = BookFunctions.GetAuthors;
            //fptr = BookFunctions.GetPrice; 
            //LibraryEngine.processBooks(books ,fptr);
            #endregion


            #region Anonymous Method
            //LibraryEngine.processBooks(books, delegate (Book book){ return book.ISBN; });   
            #endregion


            #region Lambda Expression
            //LibraryEngine.processBooks(books, (b) => b.PublicationDate.ToString());  
            #endregion


        }
    }
}
