using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class SchoolTeacher : Teacher
    {
        private string[] classes;

        public string[] Classes
        {
            get { return classes; }
            set { classes = value; }
        }

        public void EntertainChildren()
        {
            Console.WriteLine("I'm a school teacher. Let me entertain you!");
        }

        public void SayClasses()
        {
         
            foreach (var classs in this.classes)
            {
                Console.WriteLine(classs);
            }
        }

        public SchoolTeacher()
        {

        }

       
    }
}
