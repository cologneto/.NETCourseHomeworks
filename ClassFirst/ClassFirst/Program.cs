using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ivaylo = new Person();

            Ivaylo.Age = 24;
            Ivaylo.Name = "Ivaylo";
            Ivaylo.Job = "DEV";

            Console.WriteLine(Ivaylo.Age);
            Console.WriteLine(Ivaylo.Name);
            Console.WriteLine(Ivaylo.Job);

            Person Giorgos = new Person();

            Giorgos.Age = 24;
            Giorgos.Name = "Giorgios";
            Giorgos.Job = "DEV";

            Console.WriteLine(Giorgos.Age);
            Console.WriteLine(Giorgos.Name);
            Console.WriteLine(Giorgos.Job);

            Person Stanislav = new Person("Stanislav", 19, "student");

            Console.WriteLine(Stanislav.Age);
            Console.WriteLine(Stanislav.Name);
            Console.WriteLine(Stanislav.Job);

        }
    }
}
