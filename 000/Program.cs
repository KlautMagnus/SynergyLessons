using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;

            TakeDamage(ref health, -65);
            Console.WriteLine(health);

        }

            static void TakeDamage( ref int health, int damage)
            {
            if (damage < 0)
                throw new ArgumentException();
            if (health > damage)
                health -= damage;
            else
                health = 0;
            }
     


        /*
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
               
            try
            {
                int answer = x / y;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
            }

        }
        */

    }
    
} 

