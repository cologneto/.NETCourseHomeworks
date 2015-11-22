using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PineVersion2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter an odd number");
            int n = int.Parse(Console.ReadLine());
            int oCounter = 1;
            int emptySpaceCounter = n / 2;

            do
            {
                for (int j = 0; j < emptySpaceCounter; j++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < oCounter; i++)
                {
                    Console.Write("o");
                }

                oCounter += 2;
                emptySpaceCounter--;

                Console.WriteLine();
            } while (oCounter != n);

            for (int k = 0; k < n/2; k++)
            {
                Console.Write(" ");
                
            }
            Console.Write("|");
            Console.WriteLine();
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
