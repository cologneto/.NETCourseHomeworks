using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ParentecesPriorityCheck
{
    class Program
    {
        static void Main()
        {
            string str = "2 + (2-6))( + 6/(8 - 1)";
            bool check = false;
            char[] charArray = str.ToCharArray();
            int count = 0;

            foreach (var ch in charArray)
            {
                if (ch == '(')
                {
                    count++;
                }
                else if (ch == ')')
                {
                    count--;
                }
                if (count < 0)
                {
                    check = true;
                    break;
                }
            }


            if (count == 0 && !check)
            {
                Console.WriteLine("Good!!!");
            }
            else 
            {
                Console.WriteLine("Bad!!");
            }

        }
    }
}
