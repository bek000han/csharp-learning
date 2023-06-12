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
        }
    }
}