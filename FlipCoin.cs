using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    class FlipCoin
    {
        public void flipCoin()
        {
            Console.WriteLine("Let's flip a coin 100 times");            
            Random Rand = new Random();
            int heads = 0;
            int tails = 0;
            int result = 0;
            for (int i = 0; i < 100; i++)
            {
                result = Rand.Next(0, 2);
                if (result == 1)
                {
                    Console.WriteLine("heads" + heads);
                    heads++;
                }
                else
                {
                    Console.WriteLine("Tails" + tails);
                    tails++;
                }
            }
            Console.WriteLine("heads was flipped {0} times", heads);
            Console.WriteLine("tails was flipped {0} times", tails);
            //return result;
            int perHead = (heads / 100) * 100;
            Console.WriteLine(perHead);
            int perTail = (tails / 100)*100;
            Console.WriteLine(perTail);
        }
    }
    
}
