using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.VerticalMatrix
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter cols");
            int cols = int.Parse(Console.ReadLine());
            int[,] arr = new int[rows, cols];
            int currNumber = 1;

            for (int i = 0; i < cols; i++)
            {
                for (int k = 0; k < rows; k++)
                {
                    arr[k, i] = currNumber;
                    currNumber++;
                }
            }

            for (int m = 0; m < rows; m++)
            {
                for (int n = 0; n < cols; n++)
                {
                    Console.Write("{0, 3} ",arr[m, n]);
                }
                Console.WriteLine();
            }
        }
    }
}
