using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CustomerCredentialsValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //List<Customer> customersList = new List<Customer>() { new Customer("cologneto@abv.bg", "12efbte"), , new Customer("cologneto@abv", "12efbte") };

           
                try
                {
                    Customer cust = new Customer("pesh@abv.bg", "tosho11");
                }
                
                catch(EmailException ex) 
                {
                    Console.WriteLine(ex.Message);
                }
                catch (PasswordException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("End");
                }

     


        }

       
    }
}
