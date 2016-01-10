using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.RemovePunctuation
{
    class Program
    {
        static void Main()
        {
            
            try
            {
                StreamReader str = new StreamReader("Test/text1.txt");
                StreamWriter strWriter = new StreamWriter("text2.txt");
                using (str)
                {
                    using (strWriter)
                    {
                        string line = str.ReadLine();
                        int lineNumber = 0;
                        while (line != null)
                        {
                            lineNumber++;
                            strWriter.WriteLine(Regex.Replace(line, @"[^\w\s]", ""));
                            line = str.ReadLine();
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {

                Console.WriteLine("File not found"); 
            }
           
        }
    }
}
