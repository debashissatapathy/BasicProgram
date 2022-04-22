using System;

namespace BasicProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.EvenOdd 2.LargestNumber 3.FlipCoin 4.HarmonicNumber 5.LeapYear");
            Console.WriteLine("6.PowerOfTwo 7.PrimeFactor 8.QuotientAndRemainder 9.SwapNumber 10.VowelAndConsonant");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Enter number to get program value!");
            int i = Convert.ToInt16(Console.ReadLine());
            switch (i)
            {
                case 1:
                    EvenOdd num = new EvenOdd();
                    num.findEvenOdd();
                    break;
                case 2:
                    FindLargestNumber large = new FindLargestNumber();
                    large.largeNumber();
                    break;
                case 3:
                    FlipCoin f = new FlipCoin();
                    f.flipCoin();
                    break;
                case 4:
                    HarmonicNumber h = new HarmonicNumber();
                    h.harmonicNUmber();
                    break;
                case 5:
                    FindLeapYear leap = new FindLeapYear();
                    leap.leapYear();
                    break;
                case 6:
                    PowerOfTwo p = new PowerOfTwo();
                    p.twoThePower();
                    break;
                case 7:
                    PrimeFactor prime = new PrimeFactor();
                    prime.primeFactor();
                    break;
                case 8:
                    QuotientAndRemainder q = new QuotientAndRemainder();
                    q.chk_Qut_Remdr();
                    break;
                case 9:
                    SwapNumber s = new SwapNumber();
                    s.swap_Number();
                    break;                
                case 10:
                    VowelAndConsonant v = new VowelAndConsonant();
                    v.chkAlphabet();
                    break;
                default:
                    Console.WriteLine("Put correct number and try again!");
                    break;
            }
        }
    }
}
