using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Division
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter real number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the integer number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The result is: " + a / b);
        }
    }
}
