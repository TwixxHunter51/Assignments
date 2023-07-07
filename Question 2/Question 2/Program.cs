using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name");    // Ask for user's name
           String name =  Console.ReadLine();               // Scan for a string that user has entered and store it in the variable 'name'
            Console.WriteLine("Hello " + name);             // Print Hello with the entered name
            Console.ReadKey();                              // Do not close the window until a key is pressed
        }
    }
}
