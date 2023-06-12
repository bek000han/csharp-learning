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
            string[] total = input1.Split(' ');
            int duplicate = 0;
            int corrections = 0;
            string uniquevals = "";
            bool flag = false;

            foreach (string val in total)
            {
                if (uniquevals.Contains(val))
                {
                    continue;
                }
                else
                {
                    uniquevals += val + " ";
                }
            }
            
            uniquevals = uniquevals.Remove(uniquevals.Length-1);
            string[] uniquevalsarray = uniquevals.Split(' ');

            for (int i = 0; i < uniquevalsarray.Length; i++)
            {
                for (int j = 0; j < total.Length; j++)
                {
                    if (!uniquevalsarray[i].Equals(total[j]))
                    {
                        continue;
                    }
                    else
                    {
                        duplicate++;
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    flag = false;
                    corrections++;
                }
            }
            Console.Write(duplicate-corrections);
        }
    }
}