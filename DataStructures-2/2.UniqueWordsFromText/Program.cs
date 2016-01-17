using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.UniqueWordsFromText
{
    class Program
    {
        static void Main()
        {
            string text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum versions of Lorem Ipsum.";
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            
            HashSet<string> hash = new HashSet<string>(words);

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------Hash set------");
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }
    }
}
