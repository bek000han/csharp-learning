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
            string[] input = (Console.ReadLine()).Split(' ');
            int[] numbers = Array.ConvertAll(input, int.Parse);        
            int count = 0;
            int internalcount = 0;
            
            for (int i = numbers[0]; i < numbers[numbers.Length-1]; i++)
            {
                count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != numbers[j])
                    {
                        count++;
                    }
                    if (count == numbers.Length)
                    {
                        Console.Write(i + " ");
                        internalcount++;
                    }
                    
                }
            }

            if (internalcount == 0)
            {
                Console.WriteLine("There is no missing link!");
            }
        }
    }
}