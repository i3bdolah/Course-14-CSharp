using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic x = 1;

            Console.WriteLine(x);

            x = "A";

            Console.WriteLine(x);

            x = true;

            Console.WriteLine(x);

            Console.WriteLine("\n----\n");

            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());
        }
    }
}
