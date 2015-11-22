using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CheckStringEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            string hw = "Hello World";
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            Console.WriteLine(hw == str);
        }
    }
}
