using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea pentru n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (EstePalindrom(n))
            {
                Console.WriteLine("{0} este un numar palindrom.", n);
            }
            else
            {
                Console.WriteLine("{0} nu este un numar palindrom.", n);
            }
        }
        static bool EstePalindrom(int numar)
        {
            int numarInvers = 0;
            int numarOriginal = numar;
            while (numar > 0)
            {
                int ultimaCifra = numar % 10;
                numarInvers = numarInvers * 10 + ultimaCifra;
                numar /= 10;
            }
            return numarOriginal == numarInvers;
        }
    }
}
