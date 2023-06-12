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
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            int sum = 1;

            if (input2 < 0)
            {
                if (input1 < input2)
                {
                    int temp = input1;
                    input1 = input2;
                    input2 = temp;
                }
                if (input1 % 2 == 0)
                {
                    input1--;
                    while (input1 >= input2)
                    {
                        sum *= input1;
                        input1 -= 2;
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    while (input1 >= input2)
                    {
                        sum *= input1;
                        input1 -= 2;
                    }
                    Console.WriteLine(sum);
                }
            }
            else
            {
                if (input1 > input2)
                {
                    int temp = input1;
                    input1 = input2;
                    input2 = temp;
                }
                if (input1 % 2 == 0)
                {
                    input1++;
                    while (input1 <= input2)
                    {
                        sum *= input1;
                        input1 += 2;
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    while (input1 <= input2)
                    {
                        sum *= input1;
                        input1 += 2;
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}