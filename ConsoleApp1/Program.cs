using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string validDate = "12/20/2015";
            string unvalidDate = "1q2/20sds/sd2015";

            DateTime dt;

            if (DateTime.TryParse(validDate, out dt))
            {
                Console.WriteLine(dt.ToString());
            }
            else
            {
                Console.WriteLine($"{validDate} is not a valid date string");
            }

            if (DateTime.TryParse(unvalidDate, out dt))
            {
                Console.WriteLine(dt.ToString());
            }
            else
            {
                Console.WriteLine($"{unvalidDate} is not a valid date string");
            }
        }
    }
}
