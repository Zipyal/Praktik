using System;
class Program
{
    static void Main()
    {
        Console.Write("x=");
        float x = float.Parse(Console.ReadLine()); Console.Write("y=");
        float y = float.Parse(Console.ReadLine());
        if (x * x + y * y < 81 && x > 0) Console.WriteLine("внутри"); else if (x * x + y * y > 81 || x < 0) Console.WriteLine("вне"); else Console.WriteLine("на границе");
    }
}
