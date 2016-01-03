using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Teacher : Person, IPersonable
    {
        private string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public Teacher() { }

        public Teacher(string firstName, string lastName, int workingYears, string subject)
            : base(firstName, lastName, workingYears)
        {
            this.subject = subject;
        }

        public string CheckHomeworks()
        {
            return "I'm a teacher. I'm checking homeworks now.";
        }

        public string SayHello()
        {
            return "I'm " + this.lastName + "and I'm a teacher. Hello, there!";
        }
    }
}
