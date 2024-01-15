using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea pentru a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti valoarea pentru b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti valoarea pentru c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Ecuatia are doua solutii reale: x1 = {0}, x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Ecuatia are o solutie reala: x = {0}", x);
            }
            else
            {
                Console.WriteLine("Ecuatia nu are solutii reale.");
            }
        }
    }
}
