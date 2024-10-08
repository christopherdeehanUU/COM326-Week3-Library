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

    void DisplayInfo()
    {
        Console.WriteLine("Book Information");
        Console.WriteLine("----------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"Number of pages: {Pages}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "12345678", 200);

        Book book2 = new Book("C# Methods and Classes", "Microsoft", "55667778", 90);

        // Output the book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();
    }
}