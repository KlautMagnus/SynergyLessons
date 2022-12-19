using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {
                Console.Clear();

                double firstValue, secondValue;
                string action;

                try
                {
                    Console.WriteLine("Введите число 1");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception) 
                {

                    Console.WriteLine("данные не могут быть распознаны, попробуйте снова");
                    Console.ReadLine();
                    continue;
                }
                 
                Console.WriteLine("Выберите операцию '+' '-' '*' '/' ");
                action = (Console.ReadLine());

                if (action == "+")
                {
                    Console.WriteLine(firstValue + secondValue);
                }
                else if (action == "-")
                {
                    Console.WriteLine(firstValue - secondValue);
                }
                else if (action == "*")
                {
                    Console.WriteLine(firstValue * secondValue);
                }
                else if (action == "/")
                {
                    if (secondValue == 0)
                        Console.WriteLine("на ноль делить нельзя");
                    else
                        Console.WriteLine(firstValue / secondValue);
                }
                else
                {
                    Console.WriteLine("Ошибка! Неизвестное едйствие");
                }
                Console.ReadLine();

            }
            
        }


    }
}
