using System;

//Ввведите три числа, выведите на экран значение суммы и произведения этих чисел
namespace Homework1
{
    class HW1
    {
        static void Main(string[] args)
        {
            double firstnumber, secondnumber, thirdnumber, summvalue, multivalue;

            Console.WriteLine("Введите число 1");
            firstnumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            secondnumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 1");
            thirdnumber = double.Parse(Console.ReadLine());

            summvalue = (firstnumber + secondnumber + thirdnumber);
            Console.WriteLine("Сумма чисел составит " + summvalue);

            multivalue = (firstnumber * secondnumber * thirdnumber);
            Console.WriteLine("Произвдение чисел составит " + multivalue);

            Console.ReadLine();
        }

    }
}