using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagementApp.Models
{
    internal class Staff
    {
        public string StaffName { get; set; }
        public string Email {  get; set; }
        public string Password { get; set; }
        public int StaffNumber { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsClockedIn { get; set; }

        public bool IsActive { get; set; }

        public bool IsloggedIn { get; set; }


    }
}
