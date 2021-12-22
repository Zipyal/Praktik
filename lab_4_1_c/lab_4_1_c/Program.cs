namespace ConsoleApplication2
{
    class Program
    {
        private int f(int n)
        {
            if (n == 1) return -10; if (n == 2) return 2;
            return Math.Abs(f(n - 2)) - 6 * f(n - 1);
        }

        static void Main(string[] args)
        {
            double q = double.Parse(Console.ReadLine());
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("f(n);", n);

            Console.ReadLine();

        }

    }
}