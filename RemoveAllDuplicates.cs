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
            string checkerWord = Convert.ToString(input.ElementAt(0));   

            for (int i = 0; i < input.Length; i++)
            {
                if (checkerWord.Contains(input[i]))
                {
                    continue;
                }
                else
                {
                    checkerWord += input[i];
                }
            }
            Console.WriteLine(checkerWord);
        }
    }
}