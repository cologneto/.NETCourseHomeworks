using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MostRecentNumber
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int mostRecent = 0;
            int currNumber = 0;
            int currentCounter = 0;
            int maxCounter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                currNumber = arr[i];
                for (int k = 0; k < arr.Length; k++)
                {
                    if (i == k)
                    {
                        continue;
                    }
                    if (currNumber == arr[k])
                    {
                        currentCounter++;
                    }

                }
                if (currentCounter >= maxCounter)
                {
                    mostRecent = currNumber;
                    maxCounter = currentCounter;
                }
                currentCounter = 1;
            }

            Console.WriteLine("Number {0} is the most recent. It repeats {1} times", mostRecent, maxCounter);
        }
    }
}
