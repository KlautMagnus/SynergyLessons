using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                double firstValue, secondValue;
                
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

                string action;
                Console.WriteLine("Выберите операцию '+' '-' '*' '/' ");
                action = (Console.ReadLine());

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                            Console.WriteLine("на ноль делить нельзя");
                        else
                            Console.WriteLine(firstValue / secondValue);
                        break;

                    default:
                        Console.WriteLine("Ошибка! Неизвестное едйствие");
                        break;
                }
                Console.ReadLine();
            }
           
        }
    }
}
