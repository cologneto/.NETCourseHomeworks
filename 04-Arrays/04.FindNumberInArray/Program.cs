using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindNumberInArray
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    Console.WriteLine("The index of {1} is: {0}", i, n);
                    break;
                }
            }


        }
    }
}
