using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        string Title;
        string Author;
        string ISBN;
        int Pages;

        public Book(string bookTitle, string bookAuthor, string bookISBN, int bookPages)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
            Pages = bookPages;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Book Information");
            Console.WriteLine("----------------");
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine($"Number of pages: {Pages}");
            Console.WriteLine();
        }
    }
}
