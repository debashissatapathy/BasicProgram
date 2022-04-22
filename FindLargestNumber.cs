using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class FindLargestNumber
    {
        public void largeNumber()
        {
            Console.Write("Which number is greatest among three\n");
            Console.Write("Enter first numbers\n");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second numbers\n");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third numbers\n");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1 + "is largest number among three");
                }
                else
                {
                    Console.WriteLine(num3 + "is largest number among three");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine(num2 + "is largest number among three");
            }
            else
            {
                Console.WriteLine(num3 + "is largest number among three");
            }

        }
    }
}
