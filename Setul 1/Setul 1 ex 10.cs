using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea pentru n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (EstePrim(n))
            {
                Console.WriteLine("{0} este un numar prim.", n);
            }
            else
            {
                Console.WriteLine("{0} nu este un numar prim.", n);
            }

            Console.ReadLine();
        }
        static bool EstePrim(int numar)
        {
            if (numar < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numar); i++)
            
                if (numar % i == 0)
                {
                    return false;
                }
            
            return true;
        }
    }
}

