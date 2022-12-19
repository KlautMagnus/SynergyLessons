using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chetnost
{
    #region
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int chislo = int.Parse(Console.ReadLine());

            if (chislo % 2 == 0)
            {
                Console.WriteLine( chislo + " является чётным");
            }
            else
            {
                Console.WriteLine( chislo + " является нечётным");
            }

        }
    }
    #region
}
