using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static string GetMyName()
        {
            return "Abdullah Al-Shehri";
        }

        static void MyFirstMethod(string name, byte age = 23)
        {
            Console.WriteLine($"{name} writes his first method at the age of {age}.");
        }

        static void Main(string[] args)
        {
            MyFirstMethod(GetMyName());
        }
    }
}
