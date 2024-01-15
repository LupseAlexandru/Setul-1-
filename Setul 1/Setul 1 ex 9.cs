using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea pentru n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Divizorii lui {0} sunt:", n);

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
