using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;                          // Initiate with i=0
            for (i = 1; i <= 100; i++)          // Start the for loop with i=1, checking the condition that i must be less than 100, and increasing i by 1 in every iteration
            {
                if (i % 2 == 0)                 // Checking the condition if the remainder after dividing i by 2 is zero or not
                {
                    Console.WriteLine(i);       // If the condition is fulfilled (the number is even), print the number, otherwise go to the next iteration
                }
            }
            Console.ReadKey();                  // Do not close window until user presses a key
        }
    }
}
