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
            int input2 = Convert.ToInt32(Console.ReadLine());
            string[] inputs = input.Split(' ');
            bool flag = false;
            int i = 0;

            while (flag == false && i < inputs.Length)
            {
                if (Convert.ToInt32(inputs[i]) > input2)
                {
                    Console.Write(input2 + " ");
                    Console.Write(inputs[i] + " ");
                    flag = true;
                }
                else
                {
                    Console.Write(inputs[i] + " ");
                    i++;
                }
            }

            for (int j = i + 1; j < inputs.Length; j++)
            {
                Console.Write(inputs[j] + " ");
            }

            if (i == inputs.Length)
            {
                Console.Write(input2);
            }
        }
    }
}