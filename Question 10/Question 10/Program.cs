using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Number of Elements n");                             // Ask the user to input number n
            int n = int.Parse(Console.ReadLine());                                                  // Convert the nummber n from string to number 
            int num1 = 0; int num2 = 1;                                                             // State the first two numbers
            Console.WriteLine("Fibonacci Sequence upto "+n+" elements: \n"+num1 + "\n" +num2+" ");  // Print the first two numbers of the sequence
            for (int i = 2; i < n; i++)                                                             // Start loop for the next (n-2) numbers of the sequence
            {
                int num3 = num1 + num2;                                                             // Formula for Fibonacci Sequence
                Console.WriteLine(num3 + " ");                                                      // Print the next number of the sequence
                num1 = num2;                                                                        // Store the value of second number of sequence in the first number
                num2 = num3;                                                                        // repetition of above step for third number
            }
            Console.ReadKey();                                                                      // Do not close the window until user presses a key.
        }
    }
}
