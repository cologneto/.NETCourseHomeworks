using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _01.FiveThreadsNoPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Thread thread1 = new Thread(new ThreadClass("ONE", rand).PrintInfo);

            Thread thread2 = new Thread(new ThreadClass("TWO", rand).PrintInfo);

            Thread thread3 = new Thread(new ThreadClass("THREE", rand).PrintInfo); 
            
            Thread thread4 = new Thread(new ThreadClass("FOUR", rand).PrintInfo);

            Thread thread5 = new Thread(new ThreadClass("FIVE", rand).PrintInfo);

            Thread thread6 = new Thread(new ThreadClass("SIX", rand).PrintInfo);

            Thread thread7 = new Thread(new ThreadClass("SEVEN", rand).PrintInfo);

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();
            thread7.Start();
        }
    }
}
