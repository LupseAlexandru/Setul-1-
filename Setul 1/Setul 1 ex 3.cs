using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Introduceti valoarea pentru n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti valoarea pentru k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            if (n % k == 0)
            {
                Console.WriteLine("{0} se divide cu {1}.", n, k);
            }
            else
            {
                Console.WriteLine("{0} nu se divide cu {1}.", n, k);
            }
        }
    }
}
