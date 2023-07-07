using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number n for which the table is required");    // Ask for input integer
              int n = int.Parse(Console.ReadLine());                                    // Covert input string to number
            int counter = 1;                                                            // Initially set the counter to 1
            while (counter <= 12)                                                       // while loop to perform task only until counter is less than 12
            { int product = n * counter;                                                // Multiply the input number with counter
                Console.WriteLine(n + "X" + counter + "=" + product);                   // Print output in the form of table
                counter = counter + 1;                                                  // Increase the counter by 1
            }
            Console.ReadKey();                                                          // do not close the windoe until user presses a key
        }
    }
}
