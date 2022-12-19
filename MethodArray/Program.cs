using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodArray
{
    //написать метод для поиска элемента массива (тип элементов в массиве - int)
    // метод должен вернуть индекс первого найденного элемента ( если он будет найден)

    internal class Program
    {
        static int IndexOf(int[] array, int value) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }

            }

            return -1;
        }

        //создание параметров случайного массива
        static int[] GetRandomArray(uint length, int minValue, int maxValue)
        {
            int[] myArray = new int[length];

            Random random = new Random();
            
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(minValue, maxValue);
            }

            return myArray;

        }

        // поиск индекса числа 17
        static void Main(string[] args)
        {
            int[] myArray = GetRandomArray(10, -20, 20);

            int result = IndexOf(myArray, 17);
            Console.WriteLine(result);
        }
        
    }
}

