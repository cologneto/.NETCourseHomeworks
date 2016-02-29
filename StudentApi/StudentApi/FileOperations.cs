using StudentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace StudentApi
{
    public static class FileOperations
    {
        public const string FilePath = @"D:\DeveloperTrainings\DotNetCourse\.NETCourseHomeworks\StudentApi\StudentApi\App_Data\StudentDatabase.txt";
        public static List<Student> ReadStudentsFromDatabase()
        {
            var listOfStudents = new List<Student>();

            using (StreamReader reader = new StreamReader(FilePath))
            {
                var currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    var currentStudent = currentLine.Split('|');
                    var student = new Student(currentStudent[0].Trim(), 
                        currentStudent[1].Trim(), 
                        int.Parse(currentStudent[2].Trim()), 
                        double.Parse(currentStudent[3].Trim()));
                    listOfStudents.Add(student);

                    currentLine = reader.ReadLine();

                }
            }

            return listOfStudents;
        }

        public static bool AddStudentToStudentDatabase(Student studentToAdd) 
        {
            try
            {
                using ( StreamWriter writer = new StreamWriter(FilePath, true))
                {
                    writer.WriteLine(studentToAdd);
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}