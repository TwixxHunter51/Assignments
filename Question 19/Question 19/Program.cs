using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the height of the Right triangle:");    // Ask user for height of triangle
            int n = int.Parse(Console.ReadLine());                                  // Convert string to integer
            int i; int j;
            for (i = 1; i <= n; i++)                                                // For loop to control the number of rows
            {
                for (j = 1; j <= i; j++)                                            // For loop to control the number of columns
                {
                    Console.Write(j);                                               // Display the value of j
                }
                Console.WriteLine();                                                // New line inserted after all iterations of j are completed
            }
            Console.ReadKey();                                                      // Do not close window until user does so
        }
    }
}
