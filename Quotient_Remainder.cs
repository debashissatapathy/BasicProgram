using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class QuotientAndRemainder
    {
        public void chk_Qut_Remdr()
        {
            int a, b;
            Console.WriteLine("Enter the number to find quotient and Remainder: ");
            Console.WriteLine("Enter a value: ");
            a = int.Parse(Console.ReadLine() + "\n");
            Console.WriteLine("Enter b value: ");
            b = int.Parse(Console.ReadLine() + "\n");
            double num = Convert.ToDouble(a / b);
            Console.WriteLine("Quotient of " + a + " & " + b + " is " + num + "\n\n");



            int num1 = Convert.ToInt16(a % b);
            Console.WriteLine("Remainder of " + a + " & " + b + " is " + num1 + "\n\n");
        }
    }
}
