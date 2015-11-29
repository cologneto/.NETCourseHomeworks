using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringIntOrDouble
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose the enter data type: Enter 1 for Integer, 2 for Double and 3 for String");
            byte choice = byte.Parse(Console.ReadLine());
            string result;
            double number;

            switch (choice)
            {
                case 1:
                case 2:
                    Console.WriteLine("Enter a number:");
                    number = double.Parse(Console.ReadLine());
                    Console.WriteLine(++number);
                    break;
                case 3:
                    Console.WriteLine("Enter a string:");
                    result = Console.ReadLine();
                    Console.WriteLine(result + "*");
                    break;
                default:
                    break;
            }
        }
    }
}
