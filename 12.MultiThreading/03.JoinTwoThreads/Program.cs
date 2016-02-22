using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.JoinTwoThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadClass tc = new ThreadClass();

            tc.DoTask2();
        }
    }
}
