using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfLeapYear.models
{
    public class CalculateLeapYear
    {
        public void GetLeapyear (int[] years)
        {
            Console.WriteLine("Leap years");
            int leapYearCounter = 0;
            foreach (int year in years)
            {
                if(year <= DateTime.Now.Year)
                {
                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0 )
                    {
                        Console.WriteLine($"-------------------------{year} is a leap year------------------------");
                        leapYearCounter++;
                    }
                         Console.WriteLine($"{year} is in Century : {CalculateLeapYear.GetCentury(year)}th.");

                }
                else
                {
                Console.WriteLine($"{year} is a future year cant be checked");

                }
            }
                         Console.WriteLine($"-------------Number of leap years in the Array = {leapYearCounter}-----------------------");
        }
       
        static int GetCentury (int year)
        {
            int century = year / 100;
            return century;
        }
    }
}
