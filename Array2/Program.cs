using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] myArray = { 5, 4, 3, 2, 1 };

           
            Console.WriteLine("\nВывод массива: ");

            for (int count = myArray.Length - 1; count >= 0; count--)
            {
                Console.WriteLine(myArray[count]);
            }
        }
    }
}
