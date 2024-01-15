using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea pentru m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduceti valoarea pentru n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            AfiseazaFractieZecimalaCuPerioada(m, n);
        }
        static void AfiseazaFractieZecimalaCuPerioada(int m, int n)
        {
            if (n == 0)
            {
                Console.WriteLine("Denominatorul (n) nu poate fi zero.");
                return;
            }
            Console.Write("{0}/{1} = {2}.", m, n, m / n);

            int rest = m % n;

            if (rest == 0)
            {
  
                Console.WriteLine();
            }
            else
            {
                Console.Write(".");
                if (EsteFractieNeperiodica(n))
                {
                    AfiseazaParteZecimalaNeperiodica(rest, n);
                }
                else if (EsteFractiePeriodicaSimpla(n))
                {
                    AfiseazaParteZecimalaPeriodicaSimpla(rest, n);
                }
                else 
                {
                    AfiseazaParteZecimalaPeriodicaMixta(rest, n);
                }
            }
        }
        static bool EsteFractieNeperiodica(int n)
        {
            return n % 2 != 0 && n % 5 != 0;
        }
        static bool EsteFractiePeriodicaSimpla(int n)
        {
            return !EsteFractieNeperiodica(n);
        }
        static bool EsteFractiePeriodicaMixta(int n)
        {
            return EsteFractieNeperiodica(n) && (n % 2 == 0 || n % 5 == 0);
        }
        static void AfiseazaParteZecimalaNeperiodica(int rest, int n)
        {
            int parteZecimala = rest * 10 / n;
            Console.WriteLine(parteZecimala);
        }
        static void AfiseazaParteZecimalaPeriodicaSimpla(int rest, int n)
        {
            Dictionary<int, int> resturiVizitate = new Dictionary<int, int>();
            int parteZecimala = rest * 10 / n;
            Console.Write(parteZecimala);
            resturiVizitate[rest] = 0;

            while (rest != 0)
            {
                rest = rest * 10 % n;
                parteZecimala = rest * 10 / n;

                if (resturiVizitate.ContainsKey(rest))
                {
                    Console.Write("(");
                    int pozitieInceputPerioada = resturiVizitate[rest];
                    int lungimePerioada = resturiVizitate.Count - pozitieInceputPerioada;
                    for (int i = 0; i < lungimePerioada; i++)
                    {
                        Console.Write(parteZecimala);
                        rest = rest * 10 % n;
                        parteZecimala = rest * 10 / n;
                    }
                    Console.Write(")");
                    break;
                }

                Console.Write(parteZecimala);
                resturiVizitate[rest] = resturiVizitate.Count;
            }

            Console.WriteLine();
        }
        static void AfiseazaParteZecimalaPeriodicaMixta(int rest, int n)
        {
            int factor2 = 0;
            int factor5 = 0;
            int tempN = n;

            while (tempN % 2 == 0)
            {
                factor2++;
                tempN /= 2;
            }

            while (tempN % 5 == 0)
            {
                factor5++;
                tempN /= 5;
            }

            if (tempN == 1)
            {
                AfiseazaParteZecimalaPeriodicaSimpla(rest, n);
            }
            else
            {
                Console.Write("(");
                AfiseazaParteZecimalaPeriodicaSimpla(rest, n);
                Console.Write(")");
            }
        }
    }
}

