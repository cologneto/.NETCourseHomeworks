using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace _13.WebForms.Models
{
    public class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public int Age { get; set; }
        public string Email { get; set; }

        public Credentials(string username, string password, int age, string email) 
        {
            this.Username = username;
            this.Password = password;
            this.Age = age;
            this.Email = email;
        }

        public void SaveCredentials(Credentials credentials)
        {

            //StreamReader reader = new StreamReader("credentials.txt");



            using (StreamWriter writer = new StreamWriter(@"C:\Users\colog_000\Desktop\credentials.txt", true))
            {
                writer.WriteLine("Username: " + credentials.Username);
                writer.WriteLine("Password: " + credentials.Password);
                writer.WriteLine("Age: " + credentials.Age);
                writer.WriteLine("Email address: " + credentials.Email);
                writer.WriteLine();
            }

        }

    }
}