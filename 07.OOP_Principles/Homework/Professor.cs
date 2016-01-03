using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Professor : Lecturer
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Professor() { }

        public void SayTitle()
        {
            Console.WriteLine("I'm professor! My title is {0} and I'm working as professor since {1} years", this.title, this.workingYears);
        }

        public void ExaminationConduct()
        {
            Console.WriteLine("I'm proffesor {0} {1}. I can conduct examinations.", this.firstName, this.lastName);
        }
    }
}
