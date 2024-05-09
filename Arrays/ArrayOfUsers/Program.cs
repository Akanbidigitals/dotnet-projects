using System;
using ArrayOfUsers.Models;

class Program
{
    static void Main(string[] args)
    {
        User[] users = new User[10]; // Array to store users, you can adjust the size as needed

        int userCount = 0; // Track the number of users added

        bool addMoreUsers = true;

        while (addMoreUsers && userCount < users.Length)
        {
            Console.WriteLine("Add a New User or Enter 'exit' to Quit");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            Console.Write("Enter Phone Number (11 digits): ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter Gender (Male/Female): ");
            string gender = Console.ReadLine();

            // Validate inputs
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(gender))
            {
                Console.WriteLine("All fields are required. Please try again.");
                continue;
            }

            if (name.Length < 4 || password.Length < 8)
            {
                Console.WriteLine("Name must be at least 4 characters long and password must be at least 8 characters long. Please try again.");
                continue;
            }

            if (gender.ToLower() != "male" && gender.ToLower() != "female")
            {
                Console.WriteLine("Gender can only be either 'male' or 'female'. Please try again.");
                continue;
            }

            if (phoneNumber.Length != 11 || !IsNumeric(phoneNumber))
            {
                Console.WriteLine("Phone number must be 11 digits long and contain only numbers. Please try again.");
                continue;
            }

            // Append +234 to the phone number
            phoneNumber = "+234" + phoneNumber;

            // Create a new user object
            User newUser = new User(name, email, password, phoneNumber, address, gender);

            // Add the user to the array
            users[userCount] = newUser;
            userCount++;

            Console.WriteLine("User Added Successfully!\n");

            Console.Write("Do you want to add another user? (yes/no): ");
            string choice = Console.ReadLine();

            addMoreUsers = (choice.ToLower() == "yes");
        }

        // Display all users
        Console.WriteLine("\nAll Users:");
        foreach (User user in users)
        {
            if (user != null)
            {
                Console.WriteLine($"Name: {user.Name}, Email: {user.Email}, Phone Number: {user.PhoneNumber}, Address: {user.Address}, Gender: {user.Gender}");
            }
        }
    }

    // Helper method to check if a string contains only numeric characters
    static bool IsNumeric(string value)
    {
        foreach (char c in value)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
}
