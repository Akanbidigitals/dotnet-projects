using ArrayOfUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfUsers.Actions
{
    public class Validate
    {

        public static void StartProgram(User[] user)
        {
            int arrayCounter = 3;
            User[] users = new User[arrayCounter];
            int userCounter = 0;
            //name,email,password,phonenumber,address,gender

            while(true)
            {
            Console.WriteLine("Creating new User");

                if(arrayCounter >= userCounter)
                {
                    Console.WriteLine("Enter new User Info ");

                    Console.WriteLine("Enter User name ");
                    string name = Console.ReadLine();
                    Validate.CheckIfNotNullOrEmpty(name);


                    Console.WriteLine("Enter User email ");
                    string email = Console.ReadLine();
                    Validate.CheckIfNotNullOrEmpty(email);



                    Console.WriteLine("Enter password ");
                    string password = Console.ReadLine();
                    Validate.CheckIfNotNullOrEmpty(password);


                    Console.WriteLine("Enter PhoneNumber ");
                    string phonenumber = Console.ReadLine();
                    Validate.CheckIfNotNullOrEmpty(phonenumber);
                    string numberStarter = "+234";
                    phonenumber = numberStarter + phonenumber;

                    Console.WriteLine("Enter Address ");
                    string address = Console.ReadLine();
                    Validate.CheckIfNotNullOrEmpty(address);

                    Console.WriteLine("Enter gender ");
                    string gender = Console.ReadLine();
                    gender = Validate.ValidateGender(gender);
                    Validate.CheckIfNotNullOrEmpty(gender);





                    if (name.Length >= 4 && password.Length >= 8)
                    {
                        users[userCounter] = new User(name,email,password,phonenumber,address,gender);

                        userCounter ++;
                        Console.WriteLine("User added Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Pls the name is at least 4 characters and the password at least 8 characters");
                    }

                    Console.WriteLine("Get all users");
                  

                    Console.WriteLine("Do you want to add another user? (yes/no)");
                    string choice = Console.ReadLine();
                    Validate.CheckIfNotNullOrEmpty(choice);
                    if (choice != "yes") break;
                   }
                else
                {
                    Console.WriteLine("You cant add new user to the array as the lenght is filled");
                }

               
            }

           

        }

        static string CheckIfNotNullOrEmpty(string text) 
        {
            if (!string.IsNullOrEmpty(text))
            {
                return text;

            }
            else
            {
                Console.WriteLine("Input cant be empty");
                return Validate.CheckIfNotNullOrEmpty(Console.ReadLine());
            }
    
        
        }

        static string ValidateGender(string input)
        {
            if ((input.ToLower() != "name" || input.ToLower() != "female"))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid gender! Gender must be 'male' or 'female'");
                return Validate.ValidateGender(Console.ReadLine());
            }
        }
       
       
       public static void GetAllUsers(User[] users)
        {
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}
