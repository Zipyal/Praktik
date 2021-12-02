using System.IO;
using System;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.WriteLine("{0}", String.Join(" ", Enumerable.Range(1, 4).Select(v => String.Join(" ", Enumerable.Range(1, 10)) + '\n')));
    }
}
