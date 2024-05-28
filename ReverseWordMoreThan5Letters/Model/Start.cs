using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordMoreThan5Letters.Model
{
    internal class Start
    {
        public string ReverseWordWith5Letters(string input)
        {
            string[] splitInput = input.Split(' ');
            for(int i = 0; i < splitInput.Length; i++)
            {
                if (splitInput[i].Length >= 5)
                {
                    char[] charArray = splitInput[i].ToCharArray();
                    Array.Reverse(charArray);
                    splitInput[i] = new string(charArray);
                } 
            }
            string result = string.Join(" ", splitInput);
            return result;

        }
    }
}
