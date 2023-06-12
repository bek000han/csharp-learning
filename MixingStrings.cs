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

            if (input2.Length > input1.Length)
            {
                string temp = input1;
                input1 = input2;
                input2 = temp;
            }

            
            int j = 0;
            for (int i = 0; i < input1.Length; i++)
            {
                Console.Write(input1[i]);
                if (j < input2.Length)
                {
                    Console.Write(input2[j]);
                    j++;
                }
            }
        }
    }
}