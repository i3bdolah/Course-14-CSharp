using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Abdullah";

            Console.WriteLine(MyName);

            int x = 10, y = 20;
            Console.WriteLine("x=" + x);
            Console.WriteLine("y=" + y);


            Console.WriteLine("x+y=" + x + y);
            Console.WriteLine("x+y=" + (x + y));

            double MyDbl = 24.2343D;
            char MyLtr = 'a';
            bool MyBool = false;
        }
    }
}
