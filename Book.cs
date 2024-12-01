using HelperLibary;

namespace PB503_Indexer
{
    public class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public string Code;
        public Book(string name,string authorName,int pageCount,string code)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = code;
        }

    }
}
