﻿using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Sum(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        static int Sum(int Num1, int Num2, int Num3)
        {
            return Num1 + Num2 + Num3;
        }
        static int Sum(int Num1, int Num2, int Num3, int Num4)
        {
            return Num1 + Num2 + Num3 + Num4;
        }

        static void Main(string[] args)
        {
            //we have 3 diffrent methods but with the same name.
            Console.WriteLine(Sum(10, 20));
            Console.WriteLine(Sum(10, 20, 30));
            Console.WriteLine(Sum(10, 20, 30, 40));
            Console.ReadKey();
        }
    }
}
