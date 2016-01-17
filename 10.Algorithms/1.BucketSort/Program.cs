using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.BucketSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBuckets = 10;
            int[] arr = new int[12] { 22, 45, 12, 8, 10, 6, 72, 81, 33, 18, 50, 14 };
            List<int>[] buckets = new List<int>[numberOfBuckets];
            double min = arr.Min();
            double max = arr.Max();
            int divider = (int)(Math.Ceiling((max + 1) / numberOfBuckets)); 
            int bucketIndex = 0;
            int arrIndex = 0;
            Console.WriteLine(divider);

            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<int>();
            }

            for (int i = 0; i < arr.Length; i++) // can be done with 
            {
                bucketIndex = (int)(Math.Floor((double)(arr[i]/divider)));
               
                buckets[bucketIndex].Add(arr[i]); 
            }

            foreach (var item in buckets)
            {

                if (item == null)
                {
                    continue;
                }
                else
                {
                    item.Sort();
                    foreach (var item1 in item)
                    {
                        arr[arrIndex] = item1;
                        arrIndex++;
                    }
                }

            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
