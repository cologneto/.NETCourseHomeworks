using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SumAndAverageFromIntList
{
    class Program
    {
        static void Main()
        {
            
            int sum = 0;
            List<int> myList = new List<int>();
            string line = Console.ReadLine();

            while (line != string.Empty)
            {

                myList.Add(int.Parse(line));
                line = Console.ReadLine();
            }

            int number = myList.Count;
            
            foreach (var item in myList)
            {
                Console.WriteLine(item);
                sum += item;
            }

            Console.WriteLine("The average from list method is : {0}", myList.Average());
            Console.WriteLine("The sum from list method is : {0}", myList.Sum());
            Console.WriteLine("The sum is: {0}\nThe average is: {1}", sum, sum / number);
        }
    }
}
