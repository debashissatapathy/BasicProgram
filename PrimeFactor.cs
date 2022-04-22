using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class PrimeFactor
    {
        public void primeFactor()
        {
            int n, i;
            Console.WriteLine("Enter the number to find prime fnctor: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i + " is prime factor of " + n);

                }
            }
        }
    }
}
