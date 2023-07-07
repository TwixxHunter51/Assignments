﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practice_Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Array = new int[3, 3] { { 1, 661, 4 }, { 34, 6, 92 }, { 33, 44, 66 } };
            int max = 0;
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if(max < Array[i, j])
                        {
                        max = Array[i, j];
                    }
                }
            }
            Console.WriteLine("The maximum element in the array is " + max);
            Console.ReadKey();
        }
    }
}
