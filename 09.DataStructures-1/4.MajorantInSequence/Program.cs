using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MajorantInSequence
{
    class Program
    {
        static void Main()
        {
            List<int> myList = new List<int>();
            string line = Console.ReadLine();

            while (line != string.Empty)
            {

                myList.Add(int.Parse(line));
                line = Console.ReadLine();
            }

            myList.Sort();
            int index = 0;
            int curr = 0;
            bool isMajorant = false;

            while (index < myList.Count)
            {
                curr = myList[index];
                int counter = myList.LastIndexOf(curr) - index + 1;
                if (counter > (myList.Count /2))
                {
                    Console.WriteLine("The majorant is: {0} -> {1} times", curr, counter);
                    isMajorant = true;
                }
                

                index = myList.LastIndexOf(curr) + 1;

            }

            if (!isMajorant)
            {
                Console.WriteLine("The majorant does not exists!");
            }

        }
    }
}
