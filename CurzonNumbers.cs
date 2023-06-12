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
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input >= 0)
                {
                    int powersum = (Convert.ToInt32(Math.Pow(2, input)) + 1);
                    int divisor = (2 * input) + 1;
                    if (powersum % divisor == 0)
                    {
                        Console.WriteLine("True");
                    }
                    else if (powersum % divisor != 0)
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            catch
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}