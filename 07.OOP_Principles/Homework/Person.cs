using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    abstract class Person
    {
        protected string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        protected string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        protected int workingYears;

        public int WorkingYears
        {
            get { return workingYears; }
            set { workingYears = value; }
        }

        private static int counter = 0;


        public Person()
        {
            if (this.workingYears < 0)
            {
                Console.WriteLine("Please enter correct number of years working ...");
            }
            counter++;
        }

        public Person(string firstName, string lastName, int workingYears)
        {
            this.workingYears = workingYears;
            this.firstName = firstName;
            this.lastName = lastName;
            counter++;
            if (this.workingYears < 0)
            {
                Console.WriteLine("Please enter correct number of years working ...");
            }
        }

        public void PrintCounter()
        {
            Console.WriteLine("All creates classes are {0}", counter);
        }




    }
}
