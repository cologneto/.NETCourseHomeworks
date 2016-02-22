using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.WindowsForms
{
    class PersonData
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string email;


        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public PersonData(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }



        public void SavePersonDataToFile(PersonData personData)
        {
            
            //StreamReader reader = new StreamReader("personData.txt");


            
                using (StreamWriter writer = new StreamWriter("personData.txt", true))
                {
                    writer.WriteLine("First name: " + personData.firstName);
                    writer.WriteLine("Last name: " + personData.lastName);
                    writer.WriteLine("Email address: " + personData.email);
                    writer.WriteLine();
                }
            
        }

    }
}
