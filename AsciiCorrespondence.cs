using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Stash
{
    internal class Stash1
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            char ascii = Convert.ToChar(number);
            if ( (number >= 65 && number <= 90) || (number >= 97 && number <= 122) )
            {
                Console.WriteLine(ascii);
            }
            else if ( number >= 0 && number <= 64)
            {
                Console.WriteLine("A");
            }
            else if ( number >= 91 && number <= 93)
            {
                Console.WriteLine("Z");
            }
            else if ( number >= 94 && number <= 96)
            {
                Console.WriteLine("a");
            }
            else if ( number >= 123 && number <= 127)
            {
                Console.WriteLine("z");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}