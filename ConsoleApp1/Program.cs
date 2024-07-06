using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Default Values of All Types : \n");


            Console.WriteLine("Byte = " + default(Byte));
            Console.WriteLine("sbyte = " + default(sbyte));
            Console.WriteLine("short = " + default(short));
            Console.WriteLine("ushort = " + default(ushort));
            Console.WriteLine("int = " + default(int));
            Console.WriteLine("uint = " + default(uint));
            Console.WriteLine("long = " + default(long));
            Console.WriteLine("ulong = " + default(ulong));
            Console.WriteLine("float = " + default(float));
            Console.WriteLine("double = " + default(double));
            Console.WriteLine("decimal = " + default(decimal) + "\n");

            Console.WriteLine("string = " + default(string));
            Console.WriteLine("char = " + default(char));
            Console.WriteLine("bool = " + default(bool));
        }
    }
}
