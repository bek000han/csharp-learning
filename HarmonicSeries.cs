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
                string series = "1 +";
                double sum = 0;
                
                if (input > 0)
                {
                    for (int i = 2; i < input; i++)
                    {
                        series = series + $" 1/{Convert.ToString(i)} +";
                    }
                    series = series + $" 1/{Convert.ToString(input)}";
                    Console.WriteLine(series);

                    for (int i = 1; i <= input; i++)
                    {
                        sum += 1 / (Double)i;
                    }
                    Console.WriteLine("sum = " + sum.ToString("0.0000"));
                    
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