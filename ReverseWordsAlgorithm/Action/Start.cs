using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWordsAlgorithm.Action
{
    public class Start
    {
        public void ReverseWords(string words)
        {
            //Convert the word to array and split with ' '.
            string[] message = words.Split(' ');

            string[] newMessage = new string[message.Length];

            for(int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            string result = String.Join(" ", newMessage);

            Console.WriteLine(result);
        }
    }
}
