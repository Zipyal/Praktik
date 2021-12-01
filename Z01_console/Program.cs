using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    class Program : ProgramBase1
    {
private string GetDebuggerDisplay()
        {
            double x, y;
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = double.Parse(Console.ReadLine());
            if ((y < x) && (((x * x) + (y * y)) < 144))
            {
                Console.WriteLine("Точка попала в заштрихованную область");
            }
            else if ((y = x) && (((x * x) + (y * y)) == 144))
            {
                Console.WriteLine("Точка на границе заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не попала в заштрихованную область");
            }
            Console.ReadLine();
        }
    }