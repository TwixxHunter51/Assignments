using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_18
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Please Enter the number you want to check"); // Ask the user for the number
			int n = int.Parse(Console.ReadLine());                          // Convert String to integer
			int sum = 0;
			for (int i = 1; i < n; i++)                                     // For loop to run the following statements for all numbers from 1 to n
			{
				if (n % i == 0)                                             // Check for divisors of the number
				{
					sum += i;                                               // Add the divisors
				}
			}
			if (sum == n)                                                   // Check if the sum of divisors is equal to given number
			{
				Console.WriteLine("The given number is a perfect number");  // Print the results based on fulfillment of the condition
			}
			else
			{
				Console.WriteLine("The given number is not a perfect number");
			}
			Console.ReadKey();                                              // Do not close window until user does so
		}
    }
}
