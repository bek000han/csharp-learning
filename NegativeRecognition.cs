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
            double input = Convert.ToDouble(Console.ReadLine());

            if (input < 0)
            {
                Console.WriteLine(input);
            }
            else if (input > 0)
            {
                Console.WriteLine(-input);
            }
            else
            {
                Console.WriteLine("error converting");
            }
        }
    }
}