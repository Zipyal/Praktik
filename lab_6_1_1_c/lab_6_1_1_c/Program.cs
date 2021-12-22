using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размер массива:");
            var arraySize = Convert.ToInt32(Console.ReadLine());
            var array = new int[arraySize];

            for (var i = 0; i < array.Length; i++)
            {
                Console.Write("a[{0}]= ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите число:");
            var number = Convert.ToInt32(Console.ReadLine());

            var result = Array.ConvertAll(array, e => (e < number) ? number : e);

            Console.Write("Результат: ");
            foreach (var t in result)
            {
                Console.Write(t + " ");
            }

            Console.ReadLine();
        }
    }