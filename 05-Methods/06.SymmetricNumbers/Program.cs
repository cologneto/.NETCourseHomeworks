using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SymmetricNumbers
{
    class Program
    {
        static void Main()
        {
            for (int i = 10; i < 1000; i++)
            {
                FindSymmetric(i);
            }
        }

        private static void FindSymmetric(int a)
        {
            char[] arr = a.ToString().ToCharArray();

            if (arr[0] - '0' == arr[arr.Length - 1] - '0')
            {
                Console.WriteLine("The number {0} is symmetric!", a);
            }
        }
    }
}
