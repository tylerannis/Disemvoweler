using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bear could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");
            Console.ReadKey();
        }
        static void Disemvoweler(string input)
        {
            //empty variables to add into
            string output = "";
            string vowelkept = "";
           
           
            //loop through input
            for (int i = 0; i < input.Length; i++)
            {
                //search for vowels
                if ("aeiouAEIOU".Contains(input[i]))
                {
                    vowelkept = vowelkept + input[i];
                }
                    //if there is a space then do not continue through the loop, then it won't add anything to the output
                else if (input[i] == ' ')
                {
                    
                }
                else
                {
                    output = output + input[i];
                }
            }
            Console.WriteLine("Original: " + input);
            Console.WriteLine("Disemvoweled: " + output);
        }
    }
}
