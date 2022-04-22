using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class FindLeapYear
    {
        public void leapYear()
        {
            Console.WriteLine("Enter year below: ");
            int year = Convert.ToInt16(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
                Console.WriteLine(year + " is not a leap year");
        }
    }
}
