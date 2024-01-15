using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti primul an (y1): ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti ultimul an (y2): ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            if (y1 > y2)
            {
                Console.WriteLine("Intervalul nu este valid. 'y1' trebuie să fie mai mic sau egal cu 'y2'.");
            }
            else
            {
                int numarAniBisecti = 0;

                for (int an = y1; an <= y2; an++)
                {
                    if (EsteBisect(an))
                    {
                        numarAniBisecti++;
                    }
                }
                Console.WriteLine("Numarul de ani bisecti intre {0} si {1} este: {2}", y1, y2, numarAniBisecti);
            }
        }
        static bool EsteBisect(int an)
        {
            return (an % 4 == 0 && an % 100 != 0) || (an % 400 == 0);
        }
    }
}

