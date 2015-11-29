using System;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ComplicatedFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter K: ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("Enter N");
            uint k = uint.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 1; i < n; i++)
            {

                if (i <= k)
                {
                    result *= i;
                }

                if (i >= (n - k + 1))
                {
                    result *= i;
                }

            }
            Console.WriteLine(result);
        }
    }
}
