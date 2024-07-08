using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double myDbl = 100.1; // Manual Casting (Explicit)
            int myInt = (int) myDbl;


            Console.WriteLine(myInt);
            Console.WriteLine(myDbl);
        }
    }
}
