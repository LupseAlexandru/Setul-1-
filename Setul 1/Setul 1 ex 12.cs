using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea pentru n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti valoarea pentru a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti valoarea pentru b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Intervalul nu este valid. 'a' trebuie sa fie mai mic sau egal cu 'b'.");
            }
            else
            {
                int numarNumereDivizibile = 0;

                for (int i = a; i <= b; i++)
                {
                    if (i % n == 0)
                    {
                        numarNumereDivizibile++;
                    }
                }
                Console.WriteLine("Numerele divizibile cu {0} în intervalul [{1}, {2}] sunt: {3}", n, a, b, numarNumereDivizibile);
            }
        }
    }
}
