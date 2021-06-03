using System; // This is how we declare a namespace > holds classes, enums, delegates or othet namespaces.

class Program  // "Program" is a class name which holds data and methods
{
    static void Main()
    {
        Console.WriteLine($"Byte size: \n \tMaxValue: {byte.MaxValue} & MinValue: {byte.MinValue} \n \n");
        Console.WriteLine($"Int Size: \n \tMaxValue:{int.MaxValue} & MinValue: {int.MinValue}");
        Console.WriteLine($"Float size: \n \tMaxValue:{float.MaxValue} & MinValue: {float.MinValue}");
    }
}