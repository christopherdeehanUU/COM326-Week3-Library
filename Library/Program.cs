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
        Console.WriteLine("Book information");
        Console.WriteLine("----------------");
        book.DisplayInfo();
        book2.DisplayInfo();

        // Create new instances of member class
        // New members created using the member constructor in Members class
        Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
        Member member2 = new Member(2, "Chris Deehan", "102 Garden Street", 0790490620);

        Console.WriteLine("Current library members");
        Console.WriteLine("-----------------------");
        member.DisplayInfo();
        member2.DisplayInfo();
    }
}