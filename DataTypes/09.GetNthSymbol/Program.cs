using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.GetNthSymbol
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a string: ");
            string a = Console.ReadLine();
            Console.WriteLine("Please enter a character number");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("The " + index + " symbol is: " + a[index - 1] + "!");
        }
    }
}
