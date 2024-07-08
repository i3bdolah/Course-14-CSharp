using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age : ");
            //if you don't convert you will get error, and if you enter string you will get error
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is : " + (age - 1));
        }
    }
}
