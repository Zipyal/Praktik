using System;
class Program
{
    static float f(float x)
    {
        float y;
        double p = 3.14;
        if (Math.Abs(x) < p / 2)
        {
            y = (float)Math.Sin(x);
        }
        else if (Math.Abs(x) > p)
        {
            y = 0;
        }
        else
        {
            y = (float)Math.Cos(x);
        }
        return y;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите диапазон [a,b]");
        Console.Write("a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("h = ");
        float h = float.Parse(Console.ReadLine());
        Console.WriteLine();

        if (h > 0)
        {
            for (float i = a; i <= b; i += h)
            {
                Console.WriteLine("f({0}) = {1}", i, f(i));
            }
        }
        else
            Console.WriteLine("Ошибка! Некорректный ввод шага h. Введите число h больше нуля.");
    }
}
