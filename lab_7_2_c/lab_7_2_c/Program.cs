using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите слова: ");
        string[] lines = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Console.Write("Ведите нужное слово: ");
        string substring = Console.ReadLine();
        lines = lines.Where(n => n.Contains(substring)).ToArray();
        Console.WriteLine(String.Join(" ", lines));
        Console.WriteLine("Искомое слово:" + lines.OrderBy(n => n.Length).First());
        Console.ReadKey();
    }
}