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
                Console.WriteLine("Invalid input");
            }
        }
    }
}