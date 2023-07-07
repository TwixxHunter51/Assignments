using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the word you need to check:");  // Ask user for the word that needs to be checked
            string word = Console.ReadLine();                               // Scan for and store the word as a string called word
            int i; int n = word.Length; int flag = 0;
            for (i = 0; i < n / 2; i++)                                     // for loop for checking the opposing end letters of the word
            {
                if (word[i] == word[n - 1 - i])                             // Condition that the opposite letters are same. i.e. first and last letter is same, second and second last letter is same e.t.c.
                {
                    flag = 1;                                               // If condition is fulfilled, set the value of flag to be 1
                }
            }
            if(flag ==1)
            {
                Console.WriteLine("The word is a Palindrome");              // if flag is 1, display that the word is a palindrome
            }
            else
            {
                Console.WriteLine("The word is not a Palindrome");          // // if flag is 0, display that the word is not a palindrome
            }
            Console.ReadKey();
        }
    }
}
