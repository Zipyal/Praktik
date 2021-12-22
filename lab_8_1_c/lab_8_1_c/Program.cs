using System;

namespace Pr11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите осмысленное сообщения: ");
            string x = Console.ReadLine();
            Console.Write("Введите слово: ");
            string words = Console.ReadLine();

            if (x.Contains(words))
                Console.WriteLine("Сообщение содержит заданное слово");
            else
                Console.WriteLine("Сообщение не содержит заданное слово");
            Console.ReadLine();
        }
    }
}