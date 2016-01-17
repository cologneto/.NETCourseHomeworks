using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OccuringOddNumberOfTimes
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
            int counter = 0;
            Console.WriteLine(myList.LastIndexOf(curr) + "{0}", 1 / 2);

            while (index < myList.Count)
            {
                curr = myList[index];
                counter = (myList.LastIndexOf(curr) - index) + 1;
                
                if (((counter % 2) == 0) && (counter != 1))
                {
                    Console.WriteLine("in");
                    for (int i = 1; i <= counter; i++)
                    {
                        resultList.Add(curr);

                    }
                }
                index = myList.LastIndexOf(curr) + 1;


            }

            foreach (var item in resultList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
