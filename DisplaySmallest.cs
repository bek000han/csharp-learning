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
             var inputstart = Console.ReadLine();
            int small = Convert.ToInt32(inputstart);

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "X")
                {
                    Console.WriteLine(small);
                    return;
                }
                else
                {
                    if (Convert.ToInt32(input) < small)
                    {
                        small = Convert.ToInt32(input);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}