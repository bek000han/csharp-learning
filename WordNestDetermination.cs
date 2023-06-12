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
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string comparison = "";
            int nesting = 0;
            int index = 0;
            string start = "";
            string end = "";

            if (input1 == input2)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (true)
                {
                    start = "";
                    end = "";
                    if (input2.Contains(input1))
                    {
                        index = input2.IndexOf(input1);
                        for (int i = 0; i < index; i++)
                        {
                            start += input2[i];
                        }
                        for (int i = index + input1.Length; i < input2.Length; i++)
                        {
                            end += input2[i];
                        }
                        input2 = start + end;
                        nesting++;
                    }
                    else
                    {
                        Console.WriteLine(nesting-1);
                        return;
                    }
                }
            }
        }
    }
}