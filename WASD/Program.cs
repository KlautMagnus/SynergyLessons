using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Клавиша: ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                ConsoleKey key = keyInfo.Key;
                Console.WriteLine($"\t{key}) \t{(int)key}"); 
            }
        }

        static int GetKey ()
        {
            return new Random().Next(0, 100);
        }
    }
}
