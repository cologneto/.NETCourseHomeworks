using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AlphabeticalSortWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain...";
            string[] arr = str.Split(new char[] { '.', ',', '!', ' ', '?'}, StringSplitOptions.RemoveEmptyEntries); 

            List<string> words = new List<string>(arr); 


            //{ "WHATEVER", "ZONE", "HOW", "HOWEVER", "HILL", "ANY", "ANTLER", "COW", "WHATA","WA","WAN","WANB" };
            //"Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..."
           //"There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain..."

            words.Sort();

            HashSet<string> hash = new HashSet<string>(words);
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }
    }
}
