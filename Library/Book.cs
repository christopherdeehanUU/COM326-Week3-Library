using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private string title;
        private string author;
        private string isbn;
        private int pages;

        // Title property to allow access
        // to the title private variable
        public string Title
        {
            get { return title; } // get method
            set { title = value; } // set method
        }

        public string Author
        {
            get { return author; } // get method
            set { author = value; } // set method
        }

        public string ISBN
        {
            get { return isbn; } // get method
            set { isbn = value; } // set method
        }

        public int Pages
        {
            get { return pages; } // get method
            set { pages = value; } // set method
        }

        public Book(string bookTitle, string bookAuthor, string bookISBN, int bookPages)
        {
            this.title = bookTitle;
            this.author = bookAuthor;
            this.isbn = bookISBN;
            this.pages = bookPages;
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
