using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCamelWords.Action
{
    internal class Start
    {
        public string SplitCamelCase(string input)
        {
            if(string.IsNullOrEmpty(input)) return input;

            StringBuilder sb = new StringBuilder();

           

            //loop through the string input
            for(int i = 0; i < input.Length; i++)
            {
                //Assign c to each of the character in the string
                char c = input[i];

                //Check for uppercase in the character
                if(char.IsUpper(c))
                {
                    //Append te character with capital letter with space  
                    sb.Append(' ');
                }
                //Append all the iputs in the string builder
                sb.Append(c);
            }
            //return the stringbuilder as a string
            return sb.ToString();
        }
    }
}
