using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagementApp.Models
{
    internal class Company
    {
        private List<Staff> staffList;
        private List<Admin> AdminList;
        private TimeSpan expectedWorkHours;
        private DateTime expectedArrivalTime = DateTime.Today.AddHours(8);

        public Company()
        {
            staffList = new List<Staff>();
            AdminList = new List<Admin>();

        }

        //Validate Login with Email/Name and password
        public void Login(string emailOrName, string password)
        {
            Staff staff = staffList.Find(x => x.StaffName == emailOrName || x.Email == emailOrName);
            if (staff != null && staff.Password == password)
            {
                staff.IsloggedIn = true;
                Console.WriteLine($"Welcome {staff.StaffName} ,You have successll logged in");

            }
            else
            {
                Console.WriteLine("Login failed!. Incorrect email/name or password");
            }
        }
        public void Logout(string emailOrName, string password)
        {
            Staff staff = staffList.Find(x => x.StaffName == emailOrName || x.Email == emailOrName);
            if (staff != null && staff.Password == password)
            {
                staff.IsloggedIn = false;
                Console.WriteLine($"Goodbye {staff.StaffName}You have logged out!");
            }


        }
        public void ClockedIn(Staff staff, DateTime clockedInTime)
        {
            if (!staff.IsloggedIn)
            {
                Console.WriteLine("Sorry,You need to login first!");
                return;
            }
            else
            {
                staff.IsClockedIn = true;
                Console.WriteLine($"Your Clocked in time is {clockedInTime}");
                //Calcluate Expected clocked our hours

                DateTime expectedClockedOutHours = clockedInTime.AddHours(8);
                Console.WriteLine($"Expected Clocked Out time {expectedClockedOutHours}");
            }
        }

        public void ClockedOut(Staff staff, DateTime clockedOutTime)
        {
            if (!staff.IsClockedIn)
            {
                Console.WriteLine("Sorry,you need to Clock in first");
            }
            staff.IsClockedIn = false;

            TimeSpan workedHours = clockedOutTime.Subtract(expectedArrivalTime);
            if (workedHours < TimeSpan.FromHours(8))
            {
                Console.WriteLine("You worked below 8 hours today");
            }
            else
            {
                Console.WriteLine("You have worked hard today");
            }
        }

        public void ToggleActiveSatus(Admin admin, string emailorname)
        {
            Staff staff = staffList.Find(x => x.StaffName == emailorname || x.Email == emailorname);
            if (staff != null)
            {
                staff.IsActive = !staff.IsActive;
                Console.WriteLine($"The staff name {staff.StaffName} and the active status is {staff.IsActive}");
            }
        }
        public void AddStaff(Admin admin, Staff newstaff)
        {
            staffList.Add(newstaff);
        }
        public void RemoveStaff(Admin admin, string nameOrEmail)
        {
            Staff staff = staffList.Find(x => x.StaffName == nameOrEmail || x.Email == nameOrEmail);
            if (staff != null)
            {
                Console.WriteLine($"You have succefully removed {staff.StaffName} from the list ");
                staffList.Remove(staff);
            }
            else
            {
                Console.WriteLine("Staff does not exist");
            }
        }
        public void ViewStaffDetails(Admin admin, string nameOrEmail)
        {
            Admin Admin = AdminList.Find(x => x.StaffName == admin.StaffName || x.Email == admin.Email);
            if (admin != null)
            {
                Staff staff = staffList.Find(x => x.StaffName == nameOrEmail || x.Email == nameOrEmail);
                if (staff != null)
                {
                    Console.WriteLine("--------------Staff Details");
                    Console.WriteLine($"Staff Name :{staff.StaffName}.\n Staff Number :{staff.StaffNumber}.\n Date Hired :{staff.HireDate}.\n Staff Status :{staff.IsActive}.");
                }
                else
                {
                    Console.WriteLine("Sorry the Staff details does not exist");
                }

            }
            else
            {
                Console.WriteLine("You are not Authorized to perform this action");
            }
        }
        public void GetAllstaffs(Admin admin)
        {
            if (!admin.IsloggedIn)
            {
                Console.WriteLine("You need to loggin first");
                return;
            }
            else
            {
                foreach (Staff staff in staffList)
                {
                    Console.WriteLine($"Name: {staff.StaffName}, Email: {staff.Email}, IsActive: {staff.IsActive}, IsClockedIn: {staff.IsClockedIn}");
                }
            }
        }
    }
}
