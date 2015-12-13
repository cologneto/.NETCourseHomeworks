using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxNumberMethod
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(MaxNumber(c, MaxNumber(a, b)));
        }

        private static int MaxNumber(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            else
            {
                return b;
            }
        }




    }
}
