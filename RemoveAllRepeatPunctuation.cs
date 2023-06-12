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
            string input = Console.ReadLine();
            string punctuation = ".,?!;-()[]{};'\"";
            string output = "" + input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i-1] && punctuation.Contains(input[i]))
                {
                    continue;
                }
                else
                {
                    output += input[i];
                }
            }

            Console.WriteLine(output);
        }
    }
}