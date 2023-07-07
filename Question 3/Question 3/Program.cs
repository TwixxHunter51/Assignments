using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfTwoNumbers(13,52);                                 // Call the function with input numbers
            Console.ReadKey();                                      // Do not close the window until user presses a key
        }
        static int SumOfTwoNumbers(int num1, int num2)              // Define function along with its parameters
        {
            int sum = num1 + num2;                                  // Add the two numbers
            Console.WriteLine("Sum of the two numbers is " + sum);  // Print the output sum
            return sum;                                             // Return the integer 'sum' to the line the function was called
        }
    }
}
