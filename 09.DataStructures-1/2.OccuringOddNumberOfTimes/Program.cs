using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OccuringOddNumberOfTimes
{
    class Program
    {
        static void Main()
        {
            int number = 10;

            Random rand = new Random();
            List<int> myList = new List<int>();
            List<int> resultList = new List<int>();
            for (int i = 0; i < number; i++)
            {
                myList.Add(rand.Next(1, number));
            }

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            myList.Sort();

            Console.WriteLine("Sorted List");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            int index = 0;
            int curr = myList[index];

            while (index < myList.Count)
            {
                curr = myList[index];
                var newL = myList.FindAll(i => i.Equals(curr));
                if ((newL.Count % 2) == 0)
                {
                    foreach (var item1 in newL)
                    {
                        resultList.Add(item1);
                    }
                }

                newL.Clear();
                index = myList.LastIndexOf(curr) + 1;
            } 

            Console.WriteLine("Result list");
            foreach (var a in resultList)
            {
                Console.WriteLine(a);
            }


        }


    }
}
