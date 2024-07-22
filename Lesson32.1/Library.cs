using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson32._1
{
    internal class Library
    {
        private List<Book> books;
        public Library()
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)=>books.Add(book);
        public void Remove(string name)
        {
            Book book=books.Find(p=>p.getTitle()==name)!;
            books.Remove(book);
        }
        public Book findByTitle(string title) => books.Find(p => p.getTitle() == title)!;
        public Book findByAuthor(string author) => books.Find(p => p.getAuthor() == author)!;
        public Book findByYear(int year) => books.Find(p => p.getYear() == year)!;
        public int getBookCount() => books.Count();
        public List<Book> GetBooks() => books;
    }
}
