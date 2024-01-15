using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul: ");
            int numar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti pozitia k (de la dreapta la stanga): ");
            int k = Convert.ToInt32(Console.ReadLine());

            if (k < 1)
            {
                Console.WriteLine("Pozitia k trebuie sa fie mai mare sau egala cu 1.");
            }
            else
            {
                int cifra = 0;
                for (int i = 0; i < k; i++)
                {
                    cifra = numar % 10;
                    numar /= 10;
                }
                Console.WriteLine("Cifra de la pozitia {0} de la sfarsitul numarului este: {1}", k, cifra);
            }
        }
    }
}
