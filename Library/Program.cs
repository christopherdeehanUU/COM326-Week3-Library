class Book
{
    string Title;
    string Author;
    string ISBN;
    int Pages;

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
        Book book = new Book();

        // This information is for one book in our library
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "12345678";
        book.Pages = 200;

        // Second book object
        Book book2 = new Book();
        book2.Title = "C# methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "1234566";
        book2.Pages = 156;

        // Output the book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();
    }
}