internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Enter the title of the book:");
        string bookTitle = Console.ReadLine();

        Console.WriteLine("Enter the name of the author of the book:");
        string author = Console.ReadLine();
        Console.WriteLine();


        const string file = "library.txt";
        File.WriteAllText(file, $"{bookTitle}\n{author}");
        Console.WriteLine("The data is saved in the file: library.txt");
        var content = File.ReadAllLines(file);
        Console.WriteLine("Loading data");
        Console.WriteLine();


        Console.WriteLine($"Book's title is: {content[0]}");
        Console.WriteLine($"Name of the author of the book is: {content[1]}");
        Console.ReadKey();
    }
}
