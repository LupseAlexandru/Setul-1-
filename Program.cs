using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea pentru a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti valoarea pentru b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double x = -b / a;
            Console.WriteLine("Solutia ecuatiei {0}*x + {1} = 0 este x = {2}", a, b, x);
            
        }
    }
}
