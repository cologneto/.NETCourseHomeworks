using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApi.Models
{
    public class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string faculty;

        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        private int facultyNumber;

        public int FacultyNumber
        {
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }

        private double averageAssessment;

        public double AverageAssessment
        {
            get { return averageAssessment; }
            set { averageAssessment = value; }
        }

        public Student(string name, string faculty, int facultyNumber, double averageAssessment) 
        {
            this.name = name;
            this.faculty = faculty;
            this.facultyNumber = facultyNumber;
            this.averageAssessment = averageAssessment;
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}", this.Name, this.Faculty, this.FacultyNumber, this.AverageAssessment);
        }
        

        
    }
}