using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzApp.Validators;

namespace FizzBuzzApp.Action
{
    public static class Startprogram
    {
        public static void Starting(int[] arr) 
        
        {
            ValidateOperation.Fizz(arr);
            ValidateOperation.Buzz(arr);
            ValidateOperation.FizzBuzz(arr);
        }
    }
}
