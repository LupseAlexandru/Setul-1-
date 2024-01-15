using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea laturii a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti lungimea laturii b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduceti lungimea laturii c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (EsteTriunghi(a, b, c))
            {
                Console.WriteLine("Cele trei lungimi pot forma un triunghi.");
            }
            else
            {
                Console.WriteLine("Cele trei lungimi nu pot forma un triunghi.");
            }

            Console.ReadLine();
        }

        static bool EsteTriunghi(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}

