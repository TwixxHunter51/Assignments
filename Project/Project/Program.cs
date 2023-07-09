using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence ");
            string sen = Console.ReadLine();
            if (sen.Length == 0) { Console.WriteLine("Please Enter a sentence and do not return empty string"); sen = Console.ReadLine(); }
            sen = sen.ToLower();
            string[] words = sen.Split(new string[] { " ", ",", ";", "?" }, StringSplitOptions.None); // convert string to an array of words. Also define the delimeters that could be separating the words and should not be interpreted as part of the word. Springsplitoptions.none means that empty strings, if present, should lso be a part of the output.

            // For Word Frequencies 

            int N = words.Length; bool flag = false;
            int[] frequencies = Freqcheck(words);

            for (int i = 0; i < N; i++)  // For loop to avoid repetition of words.
            {
                for (int j = 0; j < i; j++)
                {
                    if (words[j] == words[i])
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine(words[i] + ": " + frequencies[i]);
                }
                flag = false;
            }
            Console.WriteLine();

            // For generating sentences

            Console.WriteLine("Enter a number 'N': ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Random random = new Random();   //Defining random integer
            int r;
            Console.WriteLine("Generated Sentences:");
            Console.WriteLine();
            for (int i = 1; i <= N; i++)            // For loop to control number of lines
            {
                Console.Write(i + ". ");
                for (int j = 1; j <= 5; j++)        // For loop to limit number of words in a sentence to 5.
                {
                    r = random.Next(words.Length);  // Assigning random integer to r
                    Console.Write(words[r] + " ");  // Printing r-th word from the sentence
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //  For Longest Word

            int[] lengths = new int[words.Length];  // Define a new array lengths
            for (int i = 0; i < words.Length; i++)  // For loop to fill lengths entries with lengths of corresponding  words from the array words.
            {
                lengths[i] = (int)words[i].Length;
            }
            int largest = 0;
            for (int j = 0; j < lengths.Length; j++)    // For loop to identify the largest length in the lengths array
            {
                if (lengths[j] > largest)
                {
                    largest = lengths[j];
                }
            }
            string reqd = null;
            Console.WriteLine("Longest word(s):");Console.WriteLine();
            bool flag1 = false;
            for (int k = 0; k < lengths.Length; k++)    // For loop to print the word corresponding to the largest length.
            {
                if (lengths[k] == largest)
                {
                    reqd = words[k];
                    for (int f = 0; f < k; f++)
                    {
                        if (reqd == words[f])
                        {
                            flag1 = true;
                        }
                    }
                    if (flag1 == false)
                    {
                        Console.WriteLine(reqd);
                    }
                    flag1 = false;
                }
            }
            Console.WriteLine();

            // For Shortest Word

            int smallest = largest;
            for (int g = 0; g < lengths.Length; g++)    // For loop to identify the shortest length in the lengths array
            {
                if (lengths[g] < smallest)
                {
                    smallest = lengths[g];
                }
            }
            string shortest = null; bool flag2 = false;
            Console.WriteLine("Shortest word(s):"); Console.WriteLine();
            for (int s = 0; s < lengths.Length; s++)    // For loop to print the word corresponding to the shortest length
            {
                if (lengths[s] == smallest)
                {
                    shortest = words[s];
                    for (int b = 0; b < s; b++)
                    {
                        if (shortest == words[b])
                        {
                            flag2 = true;
                        }
                    }
                    if (flag2 == false)
                    {
                        Console.WriteLine(shortest);
                    }
                    flag2 = false;
                }
            }
            Console.WriteLine();

            // For word search

            Console.WriteLine("Please enter the word you want to search");
            string search = Console.ReadLine();
            Console.WriteLine();
            int m = 0; int flag3 = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == search)
                { m++; flag3 = 1; }         // m ounts how many times word appeared in the sentence
            }
            if (flag3 == 1)
            {
                Console.WriteLine("The word " + search + " appears " + m + " time(s) in the sentence.");
            }
            else
                Console.WriteLine("The requested word is not a part of this sentence.");
            Console.WriteLine();

            // For searching Palindromes

            bool palindrome = false;
            Console.WriteLine("Palindromic Words: ");
            string opposite = null; Console.WriteLine();
            for (int i = 0; i < words.Length; i++)
            {
                string wordcheck = words[i];
                int M = wordcheck.Length; int flag4 = 0;
                for (int j = 0; j < M; j++)
                {
                    opposite = opposite + wordcheck[M - 1 - j]; // fill the string opposite with reverse of the word
                    if (wordcheck == opposite)
                    { flag4 = 1; palindrome = true; }           // if the word and its oppsite are the same, identify it as a palindrome.
                }
                if (flag4 == 1)
                {
                    Console.WriteLine(words[i]);
                }
                flag4 = 0;opposite = null;
            }
            if (palindrome == false)
            {
                Console.WriteLine("There are no palindromic words in this sentence.");
            }
            Console.WriteLine();

            // For counting vowels and consonants

            int sum_v=0; int sum_c=0; string vowel1 = "a"; string vowel2 = "e"; string vowel3 = "i"; string vowel4 = "o"; string vowel5 = "u";
            Console.WriteLine("Vowels and Consonants:"); Console.WriteLine();
            for (int i=0; i < words.Length; i++)
            {
                string word = words[i];
                for(int j=0; j < word.Length; j++)
                {
                    if (Char.ToString(word[j]) == vowel1 || Char.ToString(word[j]) == vowel2 || Char.ToString(word[j]) == vowel3 || Char.ToString(word[j]) == vowel4 || Char.ToString(word[j]) == vowel5 )
                    { sum_v += 1; }
                    else { sum_c += 1; }
                }
            }
            Console.WriteLine("There are " + sum_v + " vowels and " + sum_c + " consonants in this sentence.");
            Console.ReadKey();
        }


        private static int[] Freqcheck(string[] words)  // Function to check frequency of words
        {
            Console.WriteLine("\n WORD FREQUENCY:");
            int[] frequencies = new int[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                for (int j = 0; j < words.Length; j++)
                {
                    if (word == words[j])
                    {
                        frequencies[i]++;
                    }
                }
            }

            return frequencies;
        }
    }
}