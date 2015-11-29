using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Write number n = ");
        int n = int.Parse(Console.ReadLine());
        int divider = 21;

        for (int i = 1; i <= n; i++)
        {
            if (i % divider == 0)
            {
                continue;
            }
            Console.WriteLine("{0} ", i);
        }
    }
}