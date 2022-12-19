using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                {5, 17, 24, 56, 89 },
                { 6, 7, 89, 23, 4},
                { 78, 34, 23, 23, 2},
                {90, 1, 23, 67, 3 },
                {88, 2, 7, 9, 0 }

            };

            int height = array.GetLength(0);
            int width = array.GetLength(1);

            for (int y = 0; y <height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(array[x, y]+ "\t");
                }
                Console.WriteLine(" ");

            }
                
        }
    }
}
