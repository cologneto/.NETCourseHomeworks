using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            List<string> names = new List<string>{
                "Jeremy",
                "Jeferrey",
                "Joan",
                "Junky",
                "Jenifer"
            };

            var namesWithE = names.FindAll(FindNamesWithE);

            foreach (var item in namesWithE)
            {
                Console.WriteLine(item);
            }
        }

        static bool FindNamesWithE(string name) 
        {
            return name.IndexOf("e") == 1;
        }
    }
}
