using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multiplication
{
    class Program
    {
        static void Main()
        {
            Random a = new Random();

            for (int i = 0; i < 10; i++)
            {
                //Multiply(1,2,3);
                Console.WriteLine(multiply(a.Next(1,100), a.Next(1,100), a.Next(1,100))); 
            }
        }

        private static int multiply(int p1, int p2, int p3)
        {
            return p1 * p2 * p3;
        }
    }
}
