using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Methodstring
{

    // написать метод, который выводит на экран строку. Символы строки и их количество вводятся пользователем
    internal class Program
    {

        static void Printline(string Symbols, uint SymbolsCount)
        {
            for (int i = 0; i < SymbolsCount; i++)
            {
                Console.Write(Symbols);
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ:");
            string Symbols = Console.ReadLine();

            Console.WriteLine("Введите количество символов");
            uint SymbolsCount = uint.Parse(Console.ReadLine());

            Printline(Symbols, SymbolsCount);
            Console.ReadLine();
        }
    }
}
