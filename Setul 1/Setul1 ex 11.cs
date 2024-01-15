using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea pentru n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cifrele în ordine inversa: ");
            while (n > 0)
            {
                int cifra = n % 10;
                Console.Write(cifra);
                n /= 10;
            }
        }
    }
}
