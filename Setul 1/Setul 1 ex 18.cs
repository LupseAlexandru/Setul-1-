using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea pentru n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Descompunerea in factori primi a lui {0} este: ", n);
            DescompuneInFactoriPrimi(n);
        }
        static void DescompuneInFactoriPrimi(int numar)
        {
            for (int factor = 2; factor <= numar; factor++)
            {
                int exponent = 0;

                while (numar % factor == 0)
                {
                    exponent++;
                    numar /= factor;
                }

                if (exponent > 0)
                {
                    Console.Write("{0}^{1}", factor, exponent);

                    if (numar > 1)
                    {
                        Console.Write(" x ");
                    }
                }
            }
        }

    }

}

