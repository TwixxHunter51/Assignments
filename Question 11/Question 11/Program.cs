using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 4, 9, 6, 22 };                                                       // Set up an array
            Console.WriteLine("Please enter the number you are looking for: ");                     // Ask the user for the number they're looking for
            int n = int.Parse(Console.ReadLine());                                                  // Covert string to integer
            int i;int flag = 0;
            for(i=0;i<Array.Length;i++)                                                             // For Loop to check all the elements of the array
            {
                if (Array[i]==n)                                                                    // Check if i_th element is equal to the number user entered
                {
                    flag = 1;                                                                       // If condition is fulfilled, change the value of flag to 1
                    Console.WriteLine("Your number is the " + (i + 1) + " element in the array");   // Display output if condition is fulfilled
                    break;
                }
            }
            if(flag==0)
            {
                Console.WriteLine("Your Number is not in the array");                               // If flag is zero. tell the user that the number they entered is not in the array
            }
            Console.ReadKey();                                                                      // Do not close the window until user does so
        }
    }
}
