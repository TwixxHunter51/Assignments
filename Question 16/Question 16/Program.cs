using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the word you need to reverse: ");   // Ask user fore the string
            string word = Console.ReadLine();                                   // Scan and store the string in the variable 'word'
            string opposite;                                                    // Introduce a new string to store the reveresed string
            opposite = " ";                                                     // Assign it an empty string
            int n = word.Length;                                                // Store the length of given string in n
            for (int i = 0; i < n; i++)                                         // For loop to reverde the string
            {
                opposite = opposite + word[n - 1 - i];                          // Fill the reversed string by starting from the opposite end of the given string (The next character is filled in every iteration)
            }
            Console.WriteLine("The reversed string is: " + opposite);           // Print the opposite string
            Console.ReadKey();                                                  // Do not close window until the user does so.
        }
    }
}
