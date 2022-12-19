using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiviHW
{
    //Вывести количество положительных и отрицательных чисел в массиве

    //    int[] numbers = new int[5] { -20, 1, 51, -85, -9 };
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { -20, 1, 51, -85, -9 };
            int positive = 0, negative = 0;
            foreach (var count in numbers)
            {
                if (count > 0)
                    positive++;
                else
                    negative++;
            }
            Console.WriteLine("количество положительных чисел " + positive);
            Console.WriteLine("количество отрицательных чисел " + negative);

        }
    }   
}
