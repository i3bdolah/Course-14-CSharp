﻿using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            dt1 = DateTime.Now;
            Console.WriteLine(dt1);
        }
    }
}
