using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SumOfInts
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter first number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is: {0}", x + y);
        }
    }
}
