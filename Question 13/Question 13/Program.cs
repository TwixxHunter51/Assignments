using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 78, 5, 43, 541, 43 };                   // Add an Array
            int n = Array.Length;                                   // Store the length of Array in n
            int i;int largest = Array[0];int smallest = Array[0];   
            for(i=0;i<n;i++)                                        // Start of for loop
            {
                if (Array[i] > largest)                             // Check if i_th element of the array is greater than the the variable 'largest'
                {
                    largest = Array[i];                             // if condition is fulfilled, store the corresponding value in the variable 'largest'
                }
                if(Array[i]<smallest)                               // Check if i_th element of the array is smaller than the the variable 'smallest'
                {
                    smallest = Array[i];                            // if condition is fulfilled, store the corresponding value in the variable 'smallest'
                }
            }
            Console.WriteLine("The largest number is " + largest + " and the smallest number is " + smallest);  //print results
            Console.ReadKey();                                      // Do not close window until the user does so.
        }
    }
}
