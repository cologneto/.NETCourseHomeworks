using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingNamespace
{
    class NewPerson
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        static int Counter;
        public NewPerson() 
        {
            Counter++;
        }

        public NewPerson(string name, int age, string email) 
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public void PrintPersonData() 
        {
            Console.WriteLine("Person name is: " + this.Name);
            Console.WriteLine("Person age is: " + this.Age);
            Console.WriteLine("Person e-mail is: " + this.Email);
        }

        public static void PrintInfo(NewPerson person) 
        {
            Console.WriteLine("Person name is: " + person.Name);
            Console.WriteLine("Person age is: " + person.Age);
            Console.WriteLine("Person e-mail is: " + person.Email);
        }

        public override string ToString()
        {
            return string.Format("{0} is {1} years old and e-mail is {2}", this.Name, this.Age, this.Email);
        }
    }
}
