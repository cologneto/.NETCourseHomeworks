using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Lecturer : Person, IPersonable
    {
        private int maxNumberOfLecturesPerWeek = 10;
        public int MaxNumberOfLecturesPerWeek
        {
            get { return maxNumberOfLecturesPerWeek; }
        }

        private string univercityName;

        public string UnivercityName
        {
            get { return univercityName; }
            set { univercityName = value; }
        }


        public string CheckHomeworks()
        {
            throw new NotImplementedException();
        }


        public Lecturer() { }

        public Lecturer(string firstName, string lastName, int workingYears, string univercityName)
            : base(firstName, lastName, workingYears)
        {
            this.univercityName = univercityName;
        }

        public string SayHello()
        {
            throw new NotImplementedException();
        }

        public string ExercisesConduct()
        {
            return "I conduct an exercise :)";
        }

        public string ExercisesConduct(string firstName)
        {
            return "I conduct an exercise :). My first name is: " + firstName;
        }

        public string ExercisesConduct(string firstName, string lastName)
        {
            return "I conduct an exercise :). My full name is: " + firstName + " " + lastName;
        }
    }
}
