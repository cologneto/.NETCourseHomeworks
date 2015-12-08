using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassFirst;

namespace UsingNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            NewPerson Gosho = new NewPerson();
            Gosho.Age = 18;
            Gosho.Email = "gosho@gmail.com";
            Gosho.Name = "Gosho";

            NewPerson Pesho = new NewPerson("Pesho", 20, "pesho@gmail.com");
            NewPerson Tosho = new NewPerson("Tosho", 34, "tosho@gmail.com");

            Pesho.PrintPersonData();
            Gosho.PrintPersonData();
            Tosho.PrintPersonData();

            Console.WriteLine(Pesho);
            Console.WriteLine("We created ");

        }
    }
}
