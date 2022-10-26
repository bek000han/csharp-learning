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
            /*
             * EVEN NUMBERS WITH MODULUS
             * 
            int sum = 0;
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            int input3 = Convert.ToInt32(Console.ReadLine());

            if (input1 % 2 == 0)
            {
                sum = sum + input1;
            }
            if (input2 % 2 == 0)
            {
                sum = sum + input2;
            }
            if (input3 % 2 == 0)
            {
                sum = sum + input3;
            }

            Console.WriteLine(sum);
             */

            /*
             * TRIANGLE RECOGNITION
             * 
            double sideA = Convert.ToDouble(Console.ReadLine());
            double sideB = Convert.ToDouble(Console.ReadLine());
            double sideC = Convert.ToDouble(Console.ReadLine());

            if (sideA > 0 && sideB > 0 && sideC > 0)
            {
                if (sideA == sideB && sideA == sideC)
                {
                    Console.WriteLine("equilateral");
                }
                else if ((sideA == sideB && sideA != sideC) || (sideA == sideC && sideA != sideB) 
                    || (sideB == sideC && sideB != sideA))
                {
                    Console.WriteLine("isosceles");
                }
                else
                {
                    Console.WriteLine("scalene");
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }
            */

            /*
             * ORDERING NUMS NO SHORTCUT
             * 
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double number3 = Convert.ToDouble(Console.ReadLine());
            double[] numbers = { number1, number2, number3 };

            Array.Sort(numbers);
            Array.Reverse(numbers);

            Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");
            */

            /*
             * NEGATIVE RECOGNITION
             * 
             double input = Convert.ToDouble(Console.ReadLine());

            if (input < 0)
            {
                Console.WriteLine(input);
            }
            else if (input > 0)
            {
                Console.WriteLine(-input);
            }
            else
            {
                Console.WriteLine("error converting");
            }
            */

            /*
             * MONTHS CONVERSION
             * 
             int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1: 
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("crazy input");
                    break;
            */

            /*
             * ROOTS OF AN EQUATION
             * 
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) - (4 * a * c);

            if (discriminant > 0)
            {
                double root1 = ((-b + Math.Sqrt(discriminant)) / (2 * a));
                double root2 = ((-b - Math.Sqrt(discriminant)) / (2 * a));
                Console.WriteLine($"{Math.Round(root1, 2)} {Math.Round(root2, 2)}");
            }

            else if (discriminant == 0)
            {
                double root1 = ((-b + Math.Sqrt(discriminant)) / (2 * a));
                Console.WriteLine(Math.Round(root1, 2));
            }

            else if (discriminant < 0)
            {
                Console.WriteLine("no real solution");
            }

            else
            {
                Console.WriteLine("it don't work mate, real inputs you muppet");
            }
            */

            /*
             * ASCII DETERMINATION
             * 
            string vowels = "aeiouAEIOU";
            string digits = "1234567890";
            string consonants = "qwrtypsdfghjklzxcvbnmQWRTYPSDFGHJKLZXCVBNM";
            char character = Convert.ToChar(Console.ReadLine());
            if (vowels.Contains(character))
            {
                Console.WriteLine("vowel");
            }
            else if (consonants.Contains(character))
            {
                Console.WriteLine("consonant");
            }
            else if (digits.Contains(character))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("special character");
            }
            */

            /*
             * CURZON NUMBERS
             * 
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input >= 0)
                {
                    int powersum = (Convert.ToInt32(Math.Pow(2, input)) + 1);
                    int divisor = (2 * input) + 1;
                    if (powersum % divisor == 0)
                    {
                        Console.WriteLine("True");
                    }
                    else if (powersum % divisor != 0)
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("crazy input");
                }
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
            */

            /*
             * ASCII CORRESPONDENCE
             * 
            int number = Convert.ToInt32(Console.ReadLine());
            char ascii = Convert.ToChar(number);
            if ( (number >= 65 && number <= 90) || (number >= 97 && number <= 122) )
            {
                Console.WriteLine(ascii);
            }
            else if ( number >= 0 && number <= 64)
            {
                Console.WriteLine("A");
            }
            else if ( number >= 91 && number <= 93)
            {
                Console.WriteLine("Z");
            }
            else if ( number >= 94 && number <= 96)
            {
                Console.WriteLine("a");
            }
            else if ( number >= 123 && number <= 127)
            {
                Console.WriteLine("z");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            */

            /*
             * LARGEST NUM NO SHORTCUT
             * 
            double input1 = Convert.ToDouble(Console.ReadLine());
            double input2 = Convert.ToDouble(Console.ReadLine());
            double input3 = Convert.ToDouble(Console.ReadLine());
            if (input1 > input2 && input1 > input3)
            {
                Console.WriteLine(input1);
            }
            else if (input2 > input1 && input2 > input3)
            {
                Console.WriteLine(input2);
            }
            else if (input3 > input1 && input3 > input2)
            {
                Console.WriteLine(input3);
            }
            else
            {
                Console.WriteLine("Null");
            }
            */

            /*
             * MIXING STRINGS
             * 
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
            */

            /*
             * PRIME NUMBERS BETWEEN 2 AND N
             * 
             int n = Convert.ToInt32(Console.ReadLine());
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 
                97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 
                223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 
                347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 
                463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 
                607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 
                743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 
                883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997 };


            if (n <= 2)
            {
                Console.WriteLine("crazy input");
            }
            else
            {
                if (n == 3)
                {
                    Console.WriteLine("2 3");
                }
                else
                {
                    Console.Write("2 ");
                    int temp = 2;
                    int i = 1;
                    while (temp < n)
                    {
                        Console.Write(primes[i] + " ");
                        i++;
                        temp = primes[i];
                    }
                }
            */

            /*
             * ALL ODD BETWEEN INPUTS MULTILPIED
             * 
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
            */

            /*
             * ALL LETTERS BETWEEN TWO LETTERS
             * 
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
                Console.WriteLine("crazy input");
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
            */

            /*
             * NEXT FIBONACCI NUMBER AFTER VALUE N
             * 
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
            */

            /*
             * SERIES OF NUMBERS, SMALLEST
             * 
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
            */

            /*
             * HARMONIC SERIES FOR N
             * 
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
                    Console.WriteLine("crazy input");
                }
                
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
            */

            /*
             * FACTORIAL CALCULATION
             * 
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                int sum = 1;
                if (input > 0)
                {
                    for (int i = 1; i <= input; i++)
                    {
                        sum *= i;
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    Console.WriteLine("crazy input");
                }
                
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
            */

            /*
             * FLOYD'S TRIANGLE FOR N
             * 
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(sum + " ");
                    sum++;
                }

                Console.WriteLine();
            }
            */

            /*
             * ROMAN TO DECIMAL CONVERTER
             * 
            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < (input.Length); i++)
            {
                switch (input.ElementAt(i))
                {
                    case 'M':
                        sum += 1000;
                        break;
                    case 'D':
                        sum += 500;
                        break;
                    case 'C':
                        sum += 100;
                        break;
                    case 'L':
                        sum += 50;
                        break;
                    case 'X':
                        sum += 10;
                        break;
                    case 'V':
                        sum += 5;
                        break;
                    case 'I':
                        sum += 1;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sum);
            */
        }
    }
}
