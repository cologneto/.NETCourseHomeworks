using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CustomerCredentialsValidation
{
    class Customer
    {
        private string email;

        public string Email
        {
            get { return email; }
            set 
            {
                if (EmailValidation(value))
                {
                    this.email = value;
                }
                else
                {
                    throw new EmailException("Invalid email address");
                }
               
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set 
            {
                if (PasswordValidation(value))
                {
                    this.password = value;                     
                }
                else
                {
                    throw new PasswordException("Invalid password");
                }
            }
        }

        public Customer(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        private bool PasswordValidation(string password)
        {
            if (password.Length >= 6)
            {
                foreach (char item in password)
                {
                    if (char.IsDigit(item))
                    {
                        return true;
                    }
                }

                return false;
            }
            else
            {
                return false;
            }
        }

        private bool EmailValidation(string email) 
        {
            if (email.Length > 5)
            {
                if (email.Contains('@') && email.Contains('.'))
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }

            //var addr = new System.Net.Mail.MailAddress(email);
            //if (addr.Address == email)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }


    }
}
