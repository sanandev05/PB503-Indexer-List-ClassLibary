using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Indexer
{
    public class Libary
    {
        List<Book> books=new List<Book>();
        public Book this[int index]
        {
            get => books[index];
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public List<Book> FindAllBooksByName(string name)
        {
           return books.FindAll(x => x.Name == name);
        }
        public Book? FindBookByCode(string code)
        {
            return books.Find(x => x.Code == code);
        }
        public void RemoveAllBooksByName(string name)
        {
            int index=books.RemoveAll(x=> x.Name == name);
        }
        public List<Book> SearchBooks(string name)
        {
            return books.FindAll(x => x.Name == name);
        }
        public List<Book> FindAllBooksByPageCountRange(int min,int max)
        {
            List<Book> result = new List<Book>();  
            foreach (Book book in books)
            {
                if(book.PageCount<=min&&book.PageCount <= max)
                {
                    result.Add(book);
                }
            }
            return result;
        }
        public void RemoveByCode(string code)
        {
             books.RemoveAll(x => x.Code == code);
        }
        public List<Book> GetAllBooks()
        {
            return books;
        }
    }
}
