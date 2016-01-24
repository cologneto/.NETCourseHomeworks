using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.FileReadWriteMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TextFileToString("text1.txt"));
            StringToTextFile(TextFileToString("text1.txt"), "text2.txt");
        }

        public static string TextFileToString(string fileName)
        {
            string fileAsString = "";
            StreamReader reader = new StreamReader("../../" + fileName, true);
            using (reader)
            {
                fileAsString = reader.ReadToEnd();
                Console.WriteLine(reader.CurrentEncoding);
            }
            
            return fileAsString;
        }

        public static void StringToTextFile(string str, string fileName) 
        {
            StreamWriter writer = new StreamWriter(string.Format("../../{0}", fileName));

            using (writer)
            {
                writer.Write(str);
            }
        }
    }
}
