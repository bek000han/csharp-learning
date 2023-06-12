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
            char input1 = Convert.ToChar(Console.ReadLine());
            char input2 = Convert.ToChar(Console.ReadLine());
            int start = 0;
            int end = 0;
            string vowels = "aeiou";
            string Cvowels = "AEIOU";
            char[] cons = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r',
            's', 't', 'v','w', 'x', 'y', 'z' };
            char[] Ccons = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R',
            'S', 'T', 'V','W', 'X', 'Y', 'Z' };


            if (input1 > input2)
            {
                Console.WriteLine("Invalid input");
            }

            else
            {
                if (vowels.Contains(input1) | Cvowels.Contains(input1))
                {
                    switch (input1)
                    {
                        case 'a':
                        case 'A':
                            start = 0;
                            break;
                        case 'e':
                        case 'E':
                            start = 3;
                            break;
                        case 'i':
                        case 'I':
                            start = 6;
                            break;
                        case 'o':
                        case 'O':
                            start = 11;
                            break;
                        case 'u':
                        case 'U':
                            start = 16;
                            break;
                    }
                }
                else if (cons.Contains(input1) | Ccons.Contains(input1))
                {
                    int i = 0;
                    while (i <= 20)
                    {
                        if (input1 == cons[i] | input1 == Ccons[i])
                        {
                            start = i;
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                if (vowels.Contains(input2) | Cvowels.Contains(input2))
                {
                    switch (input2)
                    {
                        case 'a':
                        case 'A':
                            end = 0;
                            break;
                        case 'e':
                        case 'E':
                            end = 3;
                            break;
                        case 'i':
                        case 'I':
                            end = 6;
                            break;
                        case 'o':
                        case 'O':
                            end = 11;
                            break;
                        case 'u':
                        case 'U':
                            end = 16;
                            break;
                    }
                }
                else if (cons.Contains(input2) | Ccons.Contains(input2))
                {
                    int j = 0;
                    while (j <= 20)
                    {
                        if (input2 == cons[j] | input2 == Ccons[j])
                        {
                            end = j;
                            break;
                        }
                        else
                        {
                            j++;
                        }
                    }
                }
                for (int k = start; k <= end; k++)
                {
                    if (vowels.Contains(input1) | vowels.Contains(input2) | cons.Contains(input1) | cons.Contains(input2))
                    {
                        Console.Write(cons[k]);
                    }
                    else
                    {
                        Console.Write(Ccons[k]);
                    }
                }
            }
        }
    }
}