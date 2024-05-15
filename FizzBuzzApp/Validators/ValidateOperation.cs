using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzApp.Validators
{
    internal static class ValidateOperation
    {
        public static void Fizz (int[] num)
        {
           foreach(int i in num)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine($"{i}--Fizz");
                }
            }
        }


        public static void Buzz(int[] num)
        {
            foreach (int i in num)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}--Buzz");
                }
            }
        }


        public static void FizzBuzz(int[] num)
        {
            foreach (int i in num)
            {
                if (i % 3 == 0 && i % 5 ==0)
                {
                    Console.WriteLine($"{i}--FizzBuzz");  
                }
            }
        }
    }
}
