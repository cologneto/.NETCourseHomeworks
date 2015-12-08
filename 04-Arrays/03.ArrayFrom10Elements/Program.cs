using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ArrayFrom10Elements
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 10;
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
