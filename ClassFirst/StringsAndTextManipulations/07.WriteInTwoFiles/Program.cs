using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.WriteInTwoFiles
{
    class Program
    {
        static void Main()
        {
            try
            {
                StreamReader str = new StreamReader("text1.txt");
                StreamWriter strWriter = new StreamWriter("text2.txt");
                StreamWriter strWriter2 = new StreamWriter("text3.txt");

                using (str)
                {
                    using (strWriter)
                    {
                        using (strWriter2)
                        {
                            string line = str.ReadLine();
                            int lineNumber = 0;
                            while (line != null)
                            {
                                lineNumber++;
                                if (lineNumber % 2 == 0)
                                {
                                    strWriter2.WriteLine(lineNumber);
                                }
                                else
                                {
                                    strWriter.WriteLine(line);
                                }

                                line = str.ReadLine();
                            }
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
