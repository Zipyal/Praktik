class program
{
    public static void Main(string[] args)
    {
        Console.Write("Какой размер массива : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] myArray_2 = new int[n, n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                myArray_2[i, j] = rnd.Next(10);
                Console.Write("{0} ", myArray_2[i, j]);
            }
        }
        int Average = 0, del = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
                if (myArray_2[i, j] % 2 == 0)
                {
                    Average += myArray_2[i, j];
                    del++;
                }
        }
        Console.WriteLine("\nОтвет: {0}", Average / del);
        Console.ReadKey();
    }
}