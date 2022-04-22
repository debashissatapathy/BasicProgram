using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class PowerOfTwo
    {
        public void twoThePower()
        {
            Console.Write("Enter the value to get Power of two\n");
            int num = Convert.ToInt16(Console.ReadLine());
            int power = Convert.ToInt16(Math.Pow(2, num));
            for (int i = 0; i <= power; i++)
            {
                Console.WriteLine("power of " + i + " is " + (Math.Pow(i, 2)));
            }

        }
    }
}
