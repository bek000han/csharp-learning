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
            input = input.ToLower();
            string checkerWord = Convert.ToString(input.ElementAt(0));
            char currentletter = ' ';
            

            for (int i = 1; i < input.Length; i++)
            {
                currentletter = input[i];
                if (checkerWord.Contains(currentletter))
                {
                    Console.WriteLine("False");
                    return;
                }
                else
                {
                    checkerWord += currentletter;
                }
                if (checkerWord.Length == input.Length)
                {
                    Console.WriteLine("True");
                }
            }
        }
    }
}