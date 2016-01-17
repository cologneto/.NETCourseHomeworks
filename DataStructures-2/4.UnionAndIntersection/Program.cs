using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.UnionAndIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100000;

           
            int[] arr1 = new int[number];
            int[] arr2 = new int[number];
            int[] arr3 = new int[number];

            arr1[0] = 1;
            arr2[0] = 2;
            arr3[0] = 2;

            for (int i = 1; i < number; i++)
            {
                arr1[i] = 2 * arr1[i - 1] + 3;
                arr2[i] = 3 * arr2[i - 1] + 1;
                arr3[i] = 2 * arr3[i - 1] - 1;
            }

            HashSet<int> hash1 = new HashSet<int>(arr1);
            HashSet<int> hash2 = new HashSet<int>(arr2);
            HashSet<int> hash3 = new HashSet<int>(arr3);
            HashSet<int> Union1 = new HashSet<int>(hash1.Union(hash2)); 
            HashSet<int> Union2 = new HashSet<int>(hash2.Intersect(hash3));


        

            foreach (var item in Union2)
            {
                Console.WriteLine(item);
            }


        }
    }
}
