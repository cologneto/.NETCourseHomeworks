using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor();
            Policeman policeman = new Policeman();

            doctor.DayShifts = 5;
            doctor.NightShifts = 5;
            doctor.Salary = 10000;
            doctor.WorkingHours = 45;

            policeman.Rang = "major";
            policeman.Salary = 50;
            policeman.WorkingHours = 45;

            Console.WriteLine(policeman);
            Console.WriteLine(doctor);

        }
    }
}
