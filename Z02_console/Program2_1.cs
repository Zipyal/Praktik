using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Номер месяца = ");
        byte n = byte.Parse(Console.ReadLine());
        switch (n)
        {
            case 1: Console.WriteLine("До конца года остался " + (12 - n) + " месяц"); break;
            case 2: Console.WriteLine("До конца года осталось " + (12 - n) + " месяца"); break;
            case 3: Console.WriteLine("До конца года осталось " + (12 - n) + " месяца"); break;
            case 4: Console.WriteLine("До конца года осталось " + (12 - n) + " месяца"); break;
            case 5: Console.WriteLine("До конца года осталось " + (12 - n) + " месяца"); break;
            case 6: Console.WriteLine("До конца года осталось " + (12 - n) + " месяца"); break;
            case 7: Console.WriteLine("До конца года осталось " + (12 - n) + " месяца"); break;
            case 8: Console.WriteLine("До конца года осталось " + (12 - n) + " месяца"); break;
            case 9: Console.WriteLine("До конца года осталось " + (12 - n) + " месяца"); break;
            case 10: Console.WriteLine("До конца года осталось " + (12 - n) + " месяца"); break;
            case 11: Console.WriteLine("До конца года осталось " + (12 - n) + " месяца"); break;
            case 12: Console.WriteLine("До конца года осталось " + (12 - n) + " месяца"); break;
            default: Console.WriteLine("Такого месяца еще не придумали!"); break;

        }
        Console.ReadLine();
    }
}
