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

            string arraysum = input1 + " " + input2;

            string[] total = arraysum.Split(' ');

            for (int i = 0; i < total.Length + 1; i++)
            {
                for (int j = i + 1; j < total.Length; j++)
                {
                    if (Convert.ToInt32(total[i]) < Convert.ToInt32(total[j]))
                    {
                        string temp = total[i];
                        total[i] = total[j];
                        total[j] = temp;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            
            foreach (string item in total)
            {
                Console.Write(item + " ");
            }
        }
    }
}