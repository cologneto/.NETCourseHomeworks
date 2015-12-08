using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareArrays
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter first array length");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second array length");
            int k = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[k];
            bool areNotEqual = false;

            if (k != n)
            {
                Console.WriteLine("The arrays are not equal");
            }

            else
            {
                
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter firstArray[{0}] = ", i);
                    firstArray[i] = int.Parse(Console.ReadLine());
                    Console.Write("Enter secondArray[{0}] = ", i);
                    secondArray[i] = int.Parse(Console.ReadLine());
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("The arrays are not equal");
                        areNotEqual = true;
                        break;
                    }

                }
                if (!areNotEqual)
                {
                    Console.WriteLine("The arrays are equal!!!");
                }
            }


        }
    }
}
