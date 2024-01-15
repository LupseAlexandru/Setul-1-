using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ghiceste un numar intre 1 si 1024.");
            int limitaInferioara = 1;
            int limitaSuperioara = 1024;
            int numarGhicit = -1;

            while (limitaInferioara <= limitaSuperioara)
            {
                int mijloc = (limitaInferioara + limitaSuperioara) / 2;

                Console.Write($"Numarul este mai mare sau egal cu {mijloc}? (da/nu): ");
                string raspuns = Console.ReadLine().ToLower();
                if (raspuns == "da")
                {
                    numarGhicit = mijloc;
                    limitaInferioara = mijloc + 1;
                }
                else if (raspuns == "nu")
                {
                    limitaSuperioara = mijloc - 1;
                }
                else
                {
                    Console.WriteLine("Raspuns invalid. Raspunde cu 'da' sau 'nu'.");
                }
            }
            Console.WriteLine($"Numarul ghicit este: {numarGhicit}");
        }
    }
}

