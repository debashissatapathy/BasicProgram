using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class VowelAndConsonant
    {
        public void chkAlphabet()
        {
            Console.WriteLine("Check whether alphabet is vowel or consonant\n");
            Console.WriteLine("Enter an alphabet value\n");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("a is a vowel");
                    break;
                case 'e':
                    Console.WriteLine("e is a vowel");
                    break;
                case 'i':
                    Console.WriteLine("i is a vowel");
                    break;
                case 'o':
                    Console.WriteLine("o is a vowel");
                    break;
                case 'u':
                    Console.WriteLine("u is a vowel");
                    break;
                default:
                    Console.WriteLine("Given alphabate is a consonant");
                    break;
            }

        }
    }
}
