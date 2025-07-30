using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{

    /*Exercise 9: Create a Library class that stores a list of Book objects. 
     * Add methods add_book(book), remove_book(title), and show_books().*/
    internal class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void add_book(Book book)
        {
            books.Add(book);
        }

        public void remove_book(string title)
        {
            Book bookToRemove = books.FirstOrDefault(b => b.Title == title);
            // It will return the first book that matches the title or null if not found
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
            }
        }

        public void show_books()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.Price}");
            }
        }
    }
}
