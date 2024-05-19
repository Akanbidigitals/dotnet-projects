using StaffManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagementApp.Action
{
    internal static class Start
    {
        public static void Run()
        {

            Company company = new Company();

            
            Staff staff1 = new Staff() { StaffName = "Akanbi", StaffNumber = 101, Password = "muniru", Email = "akanbi@123.com", HireDate = new DateTime(2023, 5, 6), IsloggedIn = true };
            Admin admin1 = new Admin() { StaffName = "fortunate", StaffNumber = 110, Password = "fortune", Email = "fortunate@123.com", HireDate = new DateTime(2023, 5, 6), IsloggedIn = true };
            bool running = true;

            while (running)
            {


                Console.WriteLine("Welcome to Akanbi Staff Management App");
                Thread.Sleep(1000);
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("1. To Login.\n2. To Clock In.\n3. To Clock Out.\n4. To check Staff status.\n 5. To Logout. ");

                string userChoice = Console.ReadLine();


                switch (userChoice)
                {
                    case "1":
                        //Input name or email
                        Console.WriteLine("Pls enter Username or email");
                        string nameOrEmail = Console.ReadLine();
                        Start.Validator(nameOrEmail);

                        //Enter password
                        Console.WriteLine("Pls enter password");
                        string password = Console.ReadLine();
                        Start.Validator(password);

                        //Login
                        company.Login(nameOrEmail, password);
                        break;

                    case "2":
                        //Enter Clocked Time 
                        Console.WriteLine("Enter Clocked inTime");
                        DateTime clockedInTime = DateTime.Parse(Console.ReadLine());
                        Start.TimeValidator(clockedInTime);
                        company.ClockedIn(staff1, clockedInTime);

                        break;

                    case "3":
                        //Enter ClockedOut Time
                        Console.WriteLine("Enter Clocked inTime");
                        DateTime clockedOutTime = DateTime.Parse(Console.ReadLine());
                        Start.TimeValidator(clockedOutTime);

                        company.ClockedOut(staff1, clockedOutTime);
                        break;
                    case "4":
                        //Toggle Active
                        Console.WriteLine("Pls note only Admins can Operate this function");
                        Thread.Sleep(3000);
                        Console.WriteLine("--------------------------------------------");
                        Console.WriteLine("Pls enter name/email");
                        string checkActive = Console.ReadLine();
                        Start.Validator(checkActive);

                        company.ToggleActiveSatus(admin1, checkActive);
                        break;
                    case "5":
                        //Logout
                        //Input name or email
                        Console.WriteLine("Pls enter Username or email");
                        string nameOrE = Console.ReadLine();
                        Start.Validator(nameOrE);

                        //Enter password
                        Console.WriteLine("Pls enter password");
                        string password2 = Console.ReadLine();
                        Start.Validator(password2);

                        company.Logout(nameOrE, password2);
                        break;
                    default:
                        Console.WriteLine("Pls enter valid input");
                        return;

                }
            }










          
          

            //Add Staff




        }

        public static string Validator(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return name;
            }
            else
            {
                Console.WriteLine("Pls enter valid input");
                return Console.ReadLine();
            }
        }
        public static DateTime TimeValidator(DateTime time)
        {
            if (time != null)
            {
                return time;
            }
            else
            {
                Console.WriteLine("Input cant be null,Pls enter valid time");
                return DateTime.Parse(Console.ReadLine());

            }
        }
    }
}
