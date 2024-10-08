using Library;
class Program
{

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