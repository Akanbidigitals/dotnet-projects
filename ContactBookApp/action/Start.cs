using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactBookApp.model;
using ContactBookApp.utility;

namespace ContactBookApp.action
{
    internal class Start
    {

        public static void Run()
        {
            ContactBook contactBook = new ContactBook();
            bool running = true;

            while (running)
            {

                Console.WriteLine("1. Add Contact.");
                Console.WriteLine("2. Remove Contact.");
                Console.WriteLine("3. Get a Contact.");
                Console.WriteLine("4. Display all Contact.");
                Console.WriteLine("5. Exit");

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("-----------------------------------------");

                string userInput = Console.ReadLine();
                Start.InputValidator(userInput);

                switch (userInput)
                {
                    case "1":
                        //Enter your name
                        Console.WriteLine("Enter name : ");
                        string name = Console.ReadLine();
                        Start.InputValidator(name);

                        //Enter phone number
                        Console.WriteLine("Enter Phone number : ");
                        string phoneNumber = Console.ReadLine();
                        Start.InputValidator(phoneNumber);
                        Start.PhoneNumberValidator(phoneNumber);

                        //Add contact to the Dictionarry
                        Contact newContact = new Contact();
                        newContact.Name = name; newContact.PhoneNumber = phoneNumber;
                        contactBook.AddContact(newContact);
                        Console.WriteLine("Contact added sucessfully.");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("-----------------------------------------");
                        break;

                    case "2":
                        Console.WriteLine("Enter name of contact to remove : ");
                        string nametoRemove = Console.ReadLine();
                        Start.InputValidator(nametoRemove);
                        contactBook.RemoveContact(nametoRemove);
                        Console.WriteLine("Contact deleted sucessfully.");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("-----------------------------------------");
                        break;

                    case "3":
                        Console.WriteLine("Search contact enter name : ");
                        string nameOfContact = Console.ReadLine();
                        Start.InputValidator(nameOfContact);
                        contactBook.GetContact(nameOfContact);
                        Console.WriteLine($"Contact available");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("-----------------------------------------");
                        break;
                    case "4":
                        Console.WriteLine("Display all Contacts");
                        contactBook.GetAllContact();
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("-----------------------------------------");
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input,pls try again");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("-----------------------------------------");
                        break;

                }

            }
        }

        static string InputValidator(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Input field is required");
                return Console.ReadLine();
            }
        }
        static string PhoneNumberValidator(string input)
        {
            if (input.Length == 11 )
            {
                return input;
            }
            else
            {
                Console.WriteLine("Phone number is incorrect,Pls retry");
                return Console.ReadLine();
            }
        }

    }
}
