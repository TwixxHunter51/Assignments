using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Number n");                     // Ask the user to input number n
            int n = int.Parse(Console.ReadLine());                              // Convert the nummber n from string to number 
            bool isPrime = true;                                                // Initially consider the number to be prime
            Console.WriteLine("The Prime Numbers before n are:");               // Heading for the output before loop(If placed in loop, it would repeat after printing every number)
            for (int i = 2; i <= n; i++)                                        // Start the for loop for identifying prime numbers below n
            {
                for (int j = 2; j <= n/2; j++)                                  // For loop for diving every number by all numbers less than its half
                {

                    if (i != j && i % j == 0)                                   // Check the condition that i is less than j and the remainder is zero upon dividing i by j
                    {
                        isPrime = false;                                        // If the above condition is met, the number is not prime
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.WriteLine("\n" + i);                                // Print all prime numbers
                }
            }
            Console.ReadKey();
        }
    }
}
