using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CountOccuranciesInInterval
{
    class Program
    {
        static void Main()
        {
            int number = 1000;

            Random rand = new Random();
            List<int> myList = new List<int>();
            int[] countingArr = new int[number];

            for (int i = 0; i < 30; i++)
            {
                myList.Add(rand.Next(0, 30));
            }

            myList.Sort();

            int index = 0;
            int curr = myList[index];

            while (index < myList.Count)
            {
                curr = myList[index];
                int counter = myList.LastIndexOf(curr) - index + 1;
                countingArr[index] = counter;

                index = myList.LastIndexOf(curr) + 1;

            }

            for (int i = 0; i < countingArr.Length; i++)
            {
                if (countingArr[i] > 0)
                {
                    Console.WriteLine("Number {0} -> {1}", i, countingArr[i]);
                }
            }

            //foreach (var item in countingArr)
            //{
            //    if (item > 0)
            //    {
            //        Console.WriteLine("Number {0} -> {1}", Array.IndexOf(countingArr, item), item);
            //    }
            //}
        }
    }
}
