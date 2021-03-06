﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinimalAndMaximalOfNIntigerNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the count of numbers:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int currentNumber = int.Parse(Console.ReadLine());
            int minNumber;
            int maxNumber;
            minNumber = maxNumber = currentNumber;
            for (int i = 1; i < number; i++)
            {
                Console.WriteLine("Enter a number:");
                currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }
            Console.WriteLine("The minimal number is: {0}", minNumber);     
            Console.WriteLine("The maximal number is: {0}", maxNumber);
        }
    }
}
