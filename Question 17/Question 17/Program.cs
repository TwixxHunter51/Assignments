﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 37, 3763, 999, 12, 34 };  // Set up an array
            int n = Array.Length;
            for (int i = 0; i < (n - 1); i++)         // For Loop to perform following tasks for all alements of the array
            {
                for (int j = 0; j < (n - 1); j++)     // For Loop to perform following tasks for all elements of the array
                {
                    if (Array[j] > Array[j + 1])      // Check if the j-th element of the array is greater than the next element 
                    {
                        int temp = Array[j];          // If the above condition is met, interchange the two elements to bring the smaller element to the start of the Array
                        Array[j] = Array[j + 1];
                        Array[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + " ");        // Print the array in sorted order
            }
            Console.ReadKey();                        // Do not close window until user does so.
        }
    }
}
