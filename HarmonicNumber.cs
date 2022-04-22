using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class HarmonicNumber
    {
        public void harmonicNUmber()
        {
            int i, n;
            double sum = 0.0;

            Console.Write("Calculate the harmonic series and their sum:\n");
            Console.Write("----------------------------------------------\n");

            Console.Write("Input the number : ");
            n = Convert.ToInt16(Console.ReadLine());
            Console.Write("\n");
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                sum += 1 / (float)i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} \n", n, sum); 
        }
    }
}
