using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea pentru n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (EsteNumarCuDouaCifreRepetate(n))
            {
                Console.WriteLine("{0} este un numar format doar din doua cifre care se repeta.", n);
            }
            else
            {
                Console.WriteLine("{0} nu este un numar format doar din doua cifre.", n);
            }
        }
        static bool EsteNumarCuDouaCifreRepetate(int numar)
        {
            int cifra1 = -1;
            int cifra2 = -1;

            while (numar > 0)
            {
                int ultimaCifra = numar % 10;

                if (cifra1 == -1)
                {
                    cifra1 = ultimaCifra;
                }
                else if (cifra2 == -1 && ultimaCifra != cifra1)
                {
                    cifra2 = ultimaCifra;
                }
                else if (ultimaCifra != cifra1 && ultimaCifra != cifra2)
                {
                    return false;
                }

                numar /= 10;
            }

            return cifra1 != -1 && cifra2 != -1;
        }
    }
}

