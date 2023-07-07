using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Number n");                     // Ask the user to input number n
              int n = int.Parse(Console.ReadLine());                            // Convert the nummber n from string to number
            int sum = 0;                                                        // Initially set the sum to be equal to zero
            int counter = 1;                                                    // Set the first number to be added to be equal to 1
            while (counter <= n)                                                // Check the condition that the ccounter number is less than n
            { sum = sum + counter;                                              // Add the counter to the sum
                counter = counter + 1;                                          // Increase the counter by 1 for the next iteration
            }
            Console.WriteLine("The sum of numbers from 1 to n is " + sum);      // Print the ouput
            Console.ReadKey();                                                  // Do not close the window until user presses a button.
        }
    }
}
