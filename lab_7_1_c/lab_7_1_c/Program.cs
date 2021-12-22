using System;
using System.Text;

namespace Question2339089
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слова:");
            var s = Console.ReadLine();
            var sb = new StringBuilder(s);
            for (int i = 0; i < s.Length - 1; i += 2) // перебор с интервалом два символа.
            {
                var c = sb[i + 1]; // Вспомогательная переменная для обмена символами.
                sb[i + 1] = sb[i];
                sb[i] = c;
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}