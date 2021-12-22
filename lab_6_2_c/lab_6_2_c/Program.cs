using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размерность массива (не более 3): ");
        int size = int.Parse(Console.ReadLine());
        if (size == 1)
        {
            Console.WriteLine("Введите элементы массива:");
            int num_1 = int.Parse(Console.ReadLine());
            int[] a = { num_1 };

            int min = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            Console.WriteLine("Минимальный элемент массива: " + min);
        }
        else if (size == 1 || size == 2)
        {
            Console.WriteLine("Введите элементы массива:"); ;
            int num_1 = int.Parse(Console.ReadLine());
            int num_2 = int.Parse(Console.ReadLine());
            int[] a = { num_1, num_2 };

            int min = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            Console.WriteLine("Минимальный элемент массива: " + min);
        }
        else if (size == 1 || size == 2 || size == 3)
        {
            Console.WriteLine("Введите элементы массива:");
            int num_1 = int.Parse(Console.ReadLine());
            int num_2 = int.Parse(Console.ReadLine());
            int num_3 = int.Parse(Console.ReadLine());
            int[] a = { num_1, num_2, num_3 };

            int min = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            Console.WriteLine("Минимальный элемент массива: " + min);
        }
        else Console.WriteLine("Вы ввели не допустимый размер массива.");

        Console.ReadKey();
    }
}