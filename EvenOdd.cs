using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class EvenOdd
    {
        public void findEvenOdd()
        {
            Console.WriteLine("Enter number to find even or odd");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is a even number");
            }
            else
            {
                Console.WriteLine(num + " is a odd number");
            }
        }
    }
}
