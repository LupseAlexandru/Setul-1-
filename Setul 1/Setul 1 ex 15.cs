using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_15
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

            AfiseazaInOrdineCrescatoare(numar1, numar2, numar3);
        }
        static void AfiseazaInOrdineCrescatoare(int a, int b, int c)
        {
            if (a <= b && b <= c)
            {
                Console.WriteLine("Numerele in ordine crescatoare: {0}, {1}, {2}", a, b, c);
            }
            else if (a <= c && c <= b)
            {
                Console.WriteLine("Numerele in ordine crescatoare: {0}, {1}, {2}", a, c, b);
            }
            else if (b <= a && a <= c)
            {
                Console.WriteLine("Numerele in ordine crescatoare: {0}, {1}, {2}", b, a, c);
            }
            else if (b <= c && c <= a)
            {
                Console.WriteLine("Numerele in ordine crescatoare: {0}, {1}, {2}", b, c, a);
            }
            else if (c <= a && a <= b)
            {
                Console.WriteLine("Numerele in ordine crescatoare: {0}, {1}, {2}", c, a, b);
            }
            else 
            {
                Console.WriteLine("Numerele in ordine crescatoare: {0}, {1}, {2}", c, b, a);
            }
        }
    }
}
