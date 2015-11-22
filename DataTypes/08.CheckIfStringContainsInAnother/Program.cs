using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CheckIfStringContainsInAnother
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a string: ");
            string a = Console.ReadLine();
            Console.WriteLine("Please enter second string");
            string b = Console.ReadLine();
            Console.WriteLine("String a " + (a.Contains(b) ? "contains string b!" : "does not contains string b!"));
        }
    }
}
