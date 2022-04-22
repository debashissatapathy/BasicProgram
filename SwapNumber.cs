using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class SwapNumber
    {
        public void swap_Number()
        {
            Console.WriteLine("Let's have fun with swap number!");
            Console.WriteLine("Enter value of a");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter value of b");
            int b = Convert.ToInt16(Console.ReadLine()), c=0;
            
            c = a;
            a = b;
            b = c;
            Console.WriteLine("value of a is " + a + " & b is " + b);
        }
    }
}
