using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TheGreatestCommonDivisor
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number b = ");
            int b = int.Parse(Console.ReadLine());
            int difference = 0;
            int gcd = 0;

            if (a < 0)
            {
                a = a * (-1);
            }
            if (b < 0)
            {
                b = b * (-1);
            }
            if (a > b)
            {
                difference = a - b;
            }
            if (b > a)
            {
                difference = b - a;
            }

            for (int i = 1; i <= difference; i++)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    gcd = i;
                }
            }
            Console.WriteLine(gcd);
        }
    }
}
