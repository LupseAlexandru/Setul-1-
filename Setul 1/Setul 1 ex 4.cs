using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_1_ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Introduceti anul: ");
            int an = Convert.ToInt32(Console.ReadLine());  
            if ((an % 4 == 0 && an % 100 != 0) || (an % 400 == 0))
            {
                Console.WriteLine("{0} este un an bisect.", an);
            }
            else
            {
                Console.WriteLine("{0} nu este un an bisect.", an);
            }
        }
    }
}
