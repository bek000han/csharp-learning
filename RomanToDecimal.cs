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
            int sum = 0;

            for (int i = 0; i < (input.Length); i++)
            {
                switch (input.ElementAt(i))
                {
                    case 'M':
                        sum += 1000;
                        break;
                    case 'D':
                        sum += 500;
                        break;
                    case 'C':
                        sum += 100;
                        break;
                    case 'L':
                        sum += 50;
                        break;
                    case 'X':
                        sum += 10;
                        break;
                    case 'V':
                        sum += 5;
                        break;
                    case 'I':
                        sum += 1;
                        break;
                    default:
                        break;
                }
            }
            
            Console.WriteLine(sum);
        }
    }
}