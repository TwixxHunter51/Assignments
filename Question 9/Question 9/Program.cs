using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Number n");                     // Ask the user to input number n
            int n = int.Parse(Console.ReadLine());                              // Convert the number n from string to number
            int sum = 0;                                                        // Initially set the sum to be equal to zero
            for (int i = 1; i <= n; i++)                                        // for loop for starting i from 1, checking if its less than n, performing the task and then increasing i by 1
            {
                sum = sum + i;                                                  // Adding i to sum until the condition is failed
            }
            Console.WriteLine("The factorial of " + n + " is " + sum);          // Print the Output
            Console.ReadKey();                                                  // Do not close the window until user presses a key
        }
    }
}
