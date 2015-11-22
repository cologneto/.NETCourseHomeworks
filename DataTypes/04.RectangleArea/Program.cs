using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RectangleArea
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter side \"a\" lenght:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side \"b\"");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of rectangle is: {0}", x * y);
        }
    }
}
