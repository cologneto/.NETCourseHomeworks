﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FactorialNdividedKFactorial
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            double result = 1;

            for (double i = n - k; i < n; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
