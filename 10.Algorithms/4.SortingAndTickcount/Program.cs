using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SortingAndTickcount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10000;

            int[] array = new int[n];
            int[] array2 = new int[n];
            int[] OddArray = new int[n];
            int[] EvenArray = new int[n];
            int oddIndex = 0;
            int evenIndex = 0;
            Random rand = new Random();
            

            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(0, n); 
                array2[i] = rand.Next(0, n);
            }

            int iterations = 0;

            int start = Environment.TickCount;

            //=================selection sort Decreasing order  =========================
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j]) // swap items
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                    iterations++;
                }
            }

            //=================selection sort Increasing order the big arr =========================
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j]) // swap items
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                    iterations++;
                }
            }

            int end = Environment.TickCount - start;

            //for (int i = 0; i < array.Length; i++) // print sorted array
            //{
            //    Console.Write(array[i] + " ");
            //}

            Console.WriteLine("Time for completion for the hole array in miliseconds: {0}", end);

            Console.WriteLine("Number of iterations: " + iterations);


            

            foreach (var item in array2)
            {
                if (item % 2 == 0)
                {
                    EvenArray[evenIndex] = item;
                    evenIndex++;
                }

                else
                {
                    OddArray[oddIndex] = item;
                    oddIndex++;
                }

            }

            int start2 = Environment.TickCount;

            //=================selection sort Decreasing order  =========================
            for (int i = 0; i < EvenArray.Length - 1; i++)
            {
                for (int j = i + 1; j < EvenArray.Length; j++)
                {
                    if (EvenArray[i] < EvenArray[j]) // swap items
                    {
                        int tmp = EvenArray[i];
                        EvenArray[i] = EvenArray[j];
                        EvenArray[j] = tmp;
                    }
                    iterations++;
                }
            }


            //=================selection sort Increasing order the big arr =========================
            for (int i = 0; i < OddArray.Length - 1; i++)
            {
                for (int j = i + 1; j < OddArray.Length; j++)
                {
                    if (OddArray[i] > OddArray[j]) // swap items
                    {
                        int tmp = OddArray[i];
                        OddArray[i] = OddArray[j];
                        OddArray[j] = tmp;
                    }
                    iterations++;
                }
            }

            int end2 = Environment.TickCount - start2;

            Console.WriteLine("Time for completion for the hole array in miliseconds: {0}", end2);

            Console.WriteLine("Number of iterations: " + iterations);
        }
    }
}

