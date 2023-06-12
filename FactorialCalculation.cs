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
                int sum = 1;
                if (input > 0)
                {
                    for (int i = 1; i <= input; i++)
                    {
                        sum *= i;
                    }
                    Console.WriteLine(sum);
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