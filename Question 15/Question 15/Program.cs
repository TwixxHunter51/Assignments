using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_15
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of rows of the triangle:");  // Ask user for number of rows of triangle
            int n = int.Parse(Console.ReadLine());                                  // Convert string to integer
            int i; int j; int k;
            for (i = 1; i <= (2*n-1); i++)                                          // For loop to control the number of rows. (2n-1 because only have to print odd number of stars, so, if for 2nd row we need 3 stars: 2(2)-1=3.)
            {
                if(i%2!=0)                                                          // If condition to only allow odd number of stars
                {
                    for (k = 0; k <= ((2*n-1) - i) / 2; k++)                        // For loop to add spaces
                    {
                        Console.Write(" ");                                         // Addition of one space per iteration
                    }
                    for (j = 1; j <= i; j++)                                        // For loop to control the number of columns
                    {
                        Console.Write("*");                                         // Display a star for every iteration until j = i
                    }
                    Console.WriteLine();                                            // New Line
                }
            }
            Console.ReadKey();                                                      // Do not close window until user does so
        }
    }
}
