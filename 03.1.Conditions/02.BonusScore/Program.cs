using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            if (score >= 1 && score <= 3)
            {
                score += 5;
            }
            else if (score >= 4 && score <= 6)
            {
                score *= 12;
            }
            else
            {
                score = (score * 50) / 3;
            }
            Console.WriteLine(score);
        }
    }
}
