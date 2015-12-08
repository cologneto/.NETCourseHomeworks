using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumOfEvenNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number of element for the array:");
            int n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];
            int sum = 0;

            Random rand = new Random();

            for (int i = 0; i < n ; i++)
            {

                intArray[i] = rand.Next(1, 1000);

                if ((intArray[i] % 2) == 0)
                {
                    sum += intArray[i];
                }
                Console.Write(" {0}", intArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("The sum from all even numbers is {0}", sum);
        }
    }
}
