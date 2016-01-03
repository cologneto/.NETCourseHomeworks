using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //teacher
            Teacher teacher1 = new Teacher("Tosho", "Peshev", 12, "Heavy metal singing");
            Console.WriteLine(teacher1.SayHello());
            Console.WriteLine(teacher1.CheckHomeworks());

            //lecturer
            Lecturer lecturer1 = new Lecturer("Pesho", "Tha Big man", -18, "Pernik Univercity");
            Console.WriteLine(lecturer1.ExercisesConduct(lecturer1.FirstName, lecturer1.LastName));
            Console.WriteLine(lecturer1.ExercisesConduct(lecturer1.FirstName));
            Console.WriteLine(lecturer1.ExercisesConduct());
            
            //College teacher
            CollegeTeacher colTeacher = new CollegeTeacher();
            colTeacher.FirstName = "Ivan";
            colTeacher.LastName = "Ivanov";
            colTeacher.College = "ELSYS";
            Console.WriteLine(colTeacher.CheckHomeworks());
            Console.WriteLine();
            
            //School teacher
            SchoolTeacher schoolTeacher = new SchoolTeacher();
            schoolTeacher.FirstName = "Tosho";
            schoolTeacher.LastName = "Toshev";
            schoolTeacher.Classes = new string[] { "1A","1B","1C","1D","1E"};
            schoolTeacher.EntertainChildren();
            Console.WriteLine("These are the classes:");
            schoolTeacher.SayClasses();

            //Professor
            Console.WriteLine();
            Professor professor = new Professor();
            professor.FirstName = "Kiril";
            professor.LastName = "Iovchev";
            professor.WorkingYears = 33;
            professor.Title = "Professeur ordinaire";
            professor.SayTitle();
            professor.ExaminationConduct();
            professor.CheckHomeworks();
            
            //Assistant
            Console.WriteLine();
            Assistant assistant = new Assistant();
            assistant.FirstName = "Aleksandar";
            assistant.LastName = "Donchev";
            assistant.WorkingYears = 15;
            assistant.IsChiefAssistant = true;
            assistant.SayDetails();
            assistant.WriteArticles();
            assistant.PrintCounter();
            assistant.CheckHomeworks();

        }
    }
}
