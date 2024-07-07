﻿using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            Console.WriteLine(dateTime);

            //assigns year, month, day
            DateTime dt2 = new DateTime(2023, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2023, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);
        }
    }
}
