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
            int max = Convert.ToInt32(Console.ReadLine());
            if (max == 1)
            {
                Console.WriteLine("1 or 2");
            }
            else
            {
                int fnumber = 0;
                int current = 1;
                int previous = 0;

                while (fnumber < max)
                {
                    fnumber = current + previous;
                    previous = current;
                    current = fnumber;
                }

                fnumber = current + previous;
                previous = current;
                current = fnumber;
                Console.WriteLine(fnumber);
            }
        }
    }
}