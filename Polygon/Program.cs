using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
           uint odd = 0; //нечетные числа
           uint even = 0; //четные числа

            int oddSumm = 0;
            int evenSumm = 0;
     
            Console.WriteLine("Введите первое число диапазона");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последнее число диапазона");
            int lastNumber = int.Parse(Console.ReadLine());

            while (firstNumber <= lastNumber)

            {
                if (firstNumber % 2 == 0)
                {
                    evenSumm += firstNumber;
                    even++;
                }
                else
                {
                    oddSumm = oddSumm + firstNumber;
                    odd++;
                }
                firstNumber++;
            }
            Console.WriteLine("Количество нечетных чисел " + odd);
            Console.WriteLine("Количество четных чисел " + even);
            Console.WriteLine("Сумма нечётных чисел " + oddSumm);
            Console.WriteLine("Сумма чётных чисел " + evenSumm);
            Console.ReadLine();
        }
               
    }
}
