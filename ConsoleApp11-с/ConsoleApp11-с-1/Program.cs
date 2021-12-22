using System;

namespace ConsoleApp11_с_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите координаты x, y:");
                Point point = new Point(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));

                point.PrintPoint();

                Console.Write("Умножьте на скаляр, введите скаляр: ");
                point.MultiplyPointOnScalar = int.Parse(Console.ReadLine());

                point.PrintPoint();
                
                Console.Write("Введите два значения для перемещения точки: ");
                point.ReplacePoint(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

                point.PrintPoint();
                Console.WriteLine($"Length: {point.CalcLengthToCoordinatesStart()}");
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
