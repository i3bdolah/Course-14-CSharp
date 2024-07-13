using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {

        static void MyFirstMethod(string name, byte age)
        {
            Console.WriteLine($"{name} writes his first method at the age of {age}.");
        }

        static void Main(string[] args)
        {
            MyFirstMethod("Abdullah", 23);
        }
    }
}
