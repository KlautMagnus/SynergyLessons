using System;


//напишите программу, вычисляющую среднее арифметическое двух чисел
namespace Homework1
{
    class HW2
    {
        static void Main(string[] args)
        {
            double firstvalue, secondvalue, finalvalue;

            Console.WriteLine("Введите число 1");
            firstvalue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            secondvalue = double.Parse(Console.ReadLine());

            finalvalue = (firstvalue + secondvalue) / 2;

            Console.WriteLine("Среднее арифметическое будет " + finalvalue);
            Console.ReadLine();
        }

    }
}
/*
namespace ConsoleApp4
{

    class Program
    {
        static void Main(string[] args)
        {
            string str;
            double a;
            double b;

            Console.WriteLine("Введите первое число");
            str = Console.ReadLine();

            bool result = double.TryParse(str, out a);
            if (result == true)
            {
                Console.WriteLine("Операция успешна, значение = " + a);
            }
            else
            {
                Console.WriteLine(("Не удалось конвертировать число ")); 
            }
            Console.WriteLine("Введите второе число");
            str = Console.ReadLine();

            bool result1 = double.TryParse(str, out b);
            if (result1 == true)
            {
                Console.WriteLine("Операция успешна, значение = " + b);
            }
            else
            {
                Console.WriteLine(("Не удалось конвертировать число "));
            }
            double c = a + b;
            Console.WriteLine("Получилось " + c);
    
        }
    }
} 
  
*/