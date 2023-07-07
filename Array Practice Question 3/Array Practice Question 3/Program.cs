using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practice_Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Array = new int[3, 2] { { 1, 661 }, { 34, 6 }, { 33, 44 } };
            int sum = 0;
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    sum += Array[i, j];
                }
                int avg = sum/Array.GetLength(1);
                Console.WriteLine("The average of the " + i + " row is " + avg);
                sum = 0;
            }
            Console.ReadKey();
        }
    }
}
