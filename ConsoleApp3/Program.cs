using System;

namespace IsItALeapYear
{
    public class Program
    {
        public bool IsItALeapYear(int yr)
        {
            if ((yr % 4 == 0) && (yr % 100 != 0 || yr % 400 == 0))
            {
                Console.WriteLine(yr + "is a leap year");
                return true;
            }
            else
            {
                Console.WriteLine(yr + "is not a leap year");
                return false;
            }
        }
        static void Main(string[] args)
       // static bool Program (yr)
        {
            Console.WriteLine("Is it a leap year?!");
        }
    }
}
