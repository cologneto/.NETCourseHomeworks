using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Fibonacci
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the array length: ");
            int n = int.Parse(Console.ReadLine());
            int[] fibonacciArray = new int[n];

            fibonacciArray[0] = 0;
            fibonacciArray[1] = 1;


            for (int i = 2; i < n; i++)
            {
                fibonacciArray[i] = fibonacciArray[i - 2] + fibonacciArray[i - 1]; 
            }

            foreach (var item in fibonacciArray)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
