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
            string vowels = "aeiouAEIOU";
            string digits = "1234567890";
            string consonants = "qwrtypsdfghjklzxcvbnmQWRTYPSDFGHJKLZXCVBNM";
            char character = Convert.ToChar(Console.ReadLine());
            if (vowels.Contains(character))
            {
                Console.WriteLine("vowel");
            }
            else if (consonants.Contains(character))
            {
                Console.WriteLine("consonant");
            }
            else if (digits.Contains(character))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("special character");
            }
        }
    }
}