using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul numar: ");
            int numar1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti al doilea numar: ");
            int numar2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti al treilea numar: ");
            int numar3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti al patrulea numar: ");
            int numar4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti al cincilea numar: ");
            int numar5 = Convert.ToInt32(Console.ReadLine());

            Sorteaza(ref numar1, ref numar2);
            Sorteaza(ref numar2, ref numar3);
            Sorteaza(ref numar3, ref numar4);
            Sorteaza(ref numar4, ref numar5);
            Sorteaza(ref numar1, ref numar2);
            Sorteaza(ref numar2, ref numar3);
            Sorteaza(ref numar3, ref numar4);
            Sorteaza(ref numar1, ref numar2);
            Sorteaza(ref numar2, ref numar3);
            Sorteaza(ref numar1, ref numar2);

            Console.WriteLine("Numerele in ordine crescatoare: {0}, {1}, {2}, {3}, {4}", numar1, numar2, numar3, numar4, numar5);
        }

        static void Sorteaza(ref int a, ref int b)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
        }
    }
}

