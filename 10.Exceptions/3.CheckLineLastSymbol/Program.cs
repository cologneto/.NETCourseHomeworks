using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CheckLineLastSymbol
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filePath= "text1.txt";
            StreamReader reader = new StreamReader(filePath);
            int linesCounter = 0;
            string line;
            using (reader)
            {

                while (!string.IsNullOrWhiteSpace(line = reader.ReadLine()))
                {
                    try
                    {
                        CheckForPunctuation(line);
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }  
            }

        }

        public static bool CheckForPunctuation(string line) 
        {

            
            if (char.IsPunctuation(line[line.Length - 2]))
            {
                return true;
                Console.WriteLine("Line ends with punctuation!");

            }
            else
            {
                throw new SentenceNotCompleteException(string.Format("The line {0} does not end with punctuation symbol!!!", line));
            }
            
            return false;
        }
    }
}
