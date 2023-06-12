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
            double input1 = Convert.ToDouble(Console.ReadLine());
            double input2 = Convert.ToDouble(Console.ReadLine());
            double input3 = Convert.ToDouble(Console.ReadLine());
            if (input1 > input2 && input1 > input3)
            {
                Console.WriteLine(input1);
            }
            else if (input2 > input1 && input2 > input3)
            {
                Console.WriteLine(input2);
            }
            else if (input3 > input1 && input3 > input2)
            {
                Console.WriteLine(input3);
            }
            else
            {
                Console.WriteLine("Null");
            }
        }
    }
}