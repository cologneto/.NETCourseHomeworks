using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat pesho = new Cat("pesho", 9);

            pesho.SayMyau();

            Cat[] catsArray = new Cat[10];

            for (int i = 0; i < catsArray.Length; i++)
            {
                Console.WriteLine("Please enter cat's name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter cat's age");
                int age = int.Parse(Console.ReadLine());
                catsArray[i] = new Cat(name, age);
            }

            foreach (var item in catsArray)
            {
                item.SayMyau();
            }
        }
    }
}
