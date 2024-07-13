using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next());
                Console.WriteLine(rnd.Next(5));
                Console.WriteLine(rnd.Next(5,10));
                Console.WriteLine("--------------");
            }
        }
    }
}
