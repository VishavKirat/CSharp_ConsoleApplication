using System; // "System" is a name space and a namespace is a collection of classes, namespaces, enums etc

class Program // "Program" is a clas sname and class is a collection of data and methods
{
    static void Main() // "Main is a entry point function which starts the program"
    {
        Console.WriteLine("Enter your first name: ");  // "Console" is another class name and "WriteLine" is a function of that class. Here oI'm simply loggiing the text on the screen
        String firstName = Console.ReadLine(); // Here I'm storing a string value that you will type on the console.
        Console.WriteLine("Enter your last name: "); 
        String lastName = Console.ReadLine();
        Console.WriteLine($"Welcome, {firstName} {lastName}"); // I'm logging the data stored in teh variables.
        Console.ReadKey(); // I don't want my program to end without my consent. so I have to hiit a key to close the program manually.
    }
}
