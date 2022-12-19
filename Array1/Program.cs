using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите количество элементов массива: \t");
            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"\nВведите элемент массива под индексом {i}: \t"); ;
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nВывод массива: ");  

            for (int count = 0; count < myArray.Length; count++)
            {
                Console.WriteLine(myArray[count]);
            }
        }
    }
}
