using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_20
{
    class Program
    {
        static void Main(string[] args)
        {
			string str1 = "ABCDEF";						// State the two strings
			string str2 = "AZBHCF";
			string common = "";							// State an empty string to store the common subsequence later on.
			for (int i = 0; i < str1.Length; i++)		// For loop to check letters of string 1 from 1st to last
			{
				for (int j = i; j < str2.Length; j++)   // For loop for checking letters of string 2 from letter number i to last
				{
					if (str1[i] == str2[j])				// If condition to check if the letter number i of 1st string is equal to letter number j of secong string
					{
						common = common + str1[i];		// Storing th common letters in the string called common
					}
				}
			}
			Console.WriteLine("The longest possible subsequence in the two strings is " + common);  // Print results
			Console.ReadKey();							// Do not close window until the user does so.
		}
    }
}
