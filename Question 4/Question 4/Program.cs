using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareOfNumber(253);                                         // Call the function with input number
            Console.ReadKey();                                           // Do not close the window until user presses a key
        }
 
            static void SquareOfNumber(int number)                       // Define function alongwith its parameter
            {
                int square = number * number;                            // Square the number using mathematics
                Console.WriteLine("Square of the number is " + square);  // Print the output
            }
    }
}
