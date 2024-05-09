using ArrayOfUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayOfUsers.Models;

namespace ArrayOfUsers.Actions
{
    public class Validate
    {

        public static void  StartProgram()
        {
            Console.WriteLine("Creating new User");

            string name, email,password, phoneNumber, address, gender;

            //var newUser = new User(name,email,password,phoneNumber,address,gender);

            do
            {
                Console.WriteLine("Pls enter your name");
                name = Console.ReadLine();
            }while(string.IsNullOrEmpty(name) && name.Length < 4);



            do
            {
                Console.WriteLine("Pls enter your email");
                email = Console.ReadLine();
            } while (string.IsNullOrEmpty(email));

            do
            {
                Console.WriteLine("Pls enter your phone number");
                string starting = "+234";
                phoneNumber = Console.ReadLine();
                phoneNumber = starting + phoneNumber;
            } while (string.IsNullOrEmpty(email));

            do
            {
                Console.WriteLine("Pls enter your password");
                password = Console.ReadLine();
            } while (string.IsNullOrEmpty(password) || password.Length < 8 );

            do
            {
                Console.WriteLine("Pls enter your address");
                address = Console.ReadLine();
            } while (string.IsNullOrEmpty(address));

            do
            {
                Console.WriteLine("Pls enter your gender");
                gender = Console.ReadLine();
            } while (string.IsNullOrEmpty(gender) || gender.ToLower() != "male" &&  gender.ToLower() != "female" );

        }

    }
}
