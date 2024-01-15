using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea pentru a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti valoarea pentru b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("Valorile inversate sunt: a = {0}, b = {1}", a, b);
        }
    }
}
