class program
{
    public static void Main(string[] args)
    {
        Console.Write("Сколько ступенек будет в массиве : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] myArray_1 = new int[n][];
        int[] minArray = new int[n];
        Random rnd = new Random();

        for (int i = 0; i < myArray_1.Length; i++)
        {
            Console.WriteLine();
            myArray_1[i] = new int[i + 1];
            for (int j = 0; j <= i; j++)
            {
                myArray_1[i][j] = rnd.Next(10);
                Console.Write(myArray_1[i][j] + " ");
            }
        }

        int min = 0;
        for (int i = 0; i < myArray_1.Length; i++)
        {
            min = myArray_1[i][0];
            for (int j = 0; j <= i; j++)
            {
                if (min >= myArray_1[i][j])
                    min = myArray_1[i][j];
            }
            minArray[i] = min;
        }
        Console.WriteLine("\n~~ Минимальные Элементы ~~");
        foreach (int value in minArray)
            Console.Write("{0} ", value);
        Console.ReadKey();
    }
}