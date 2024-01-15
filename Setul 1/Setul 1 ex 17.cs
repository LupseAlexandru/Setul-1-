using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul numar: ");
            int numar1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti al doilea numar: ");
            int numar2 = Convert.ToInt32(Console.ReadLine());

            int cmmd = CalculeazaCMMD(numar1, numar2);
            int cmmi = numar1 * numar2 / cmmd;

            Console.WriteLine("Cel mai mare divizor comun al celor doua numere este: {0}", cmmd);
            Console.WriteLine("Cel mai mic multiplu comun al celor doua numere este: {0}", cmmi);
        }
        static int CalculeazaCMMD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}

