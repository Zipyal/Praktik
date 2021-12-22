using System;

namespace ConsoleApp12_c_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите позиции координат (x y): ");
                Point point = (Point)Console.ReadLine();

                Console.WriteLine($"X Y равны: {(point?"да":"нет")}");

                Console.WriteLine((string)point);
                
                Console.Write("Введите скаляр: ");
                point += int.Parse(Console.ReadLine());
                Console.WriteLine((string)point);

                Console.WriteLine("++");
                point++;
                Console.WriteLine((string)point);

                Console.WriteLine("--");
                point--;
                Console.WriteLine((string)point);
            }
            catch
            {
                Console.WriteLine("ошибка");
            }
        }
    }
}
