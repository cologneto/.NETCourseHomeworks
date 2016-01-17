using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CountingWords
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            string[] lines = new string[10];
            string line = string.Empty;
            //string currentWord;
            for (int i = 0; i < 10; i++)
            {
                lines[i] = Console.ReadLine();
            }

            foreach (var item in lines)
            {
                if (!words.Keys.Contains(item))
                {
                    words.Add(item, 1);
                }
                else
                {
                    words[item] = words[item] + 1;
                }
            }
            foreach (var item in words)
            {
                Console.WriteLine("Word {0} -> {1} times", item.Key, item.Value);
            }
        }
    }
}
