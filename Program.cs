using HelperLibary;
namespace PB503_Indexer
{
    public class Program
    {
        static void Main(string[] args)
        {
            HelperLibary.Helper.CreateBookCode("BOOK", 4);
            Libary libary = new Libary();
            libary.AddBook(new Book("Book","San",45,"s1"));
            libary.AddBook(new Book("Book", "San", 45, "s2"));
            libary.AddBook(new Book("Book123", "San", 45,"s3"));
            libary.RemoveByCode("s3");
            foreach (var item in libary.GetAllBooks())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
