using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWord
{
    public class Anagram
    {
        /*public static string ReverseWord(string word)
        {

            if (word == null)
            {
                return null;
            }
            else if (word.Length == 0 || word.Length < 2)
            {
                return word;
            }

            char[] charArray = word.ToCharArray();
            int start = 0;
            int end = charArray.Length - 1;

            for (int i = 0; i < charArray.Length / 2; i++)
            {
                if (!char.IsLetter(charArray[start]))
                {
                    start++;
                }
                else if (!char.IsLetter(charArray[end]))
                {
                    end--;
                }
                else
                {
                    char step = charArray[start];
                    charArray[start] = charArray[end];
                    charArray[end] = step;
                    start++;
                    end--;
                }
            }

            string result = new string(charArray);

            return result;
        }*/

        public static string ReverseWord(string word)
        {

            if (word == null)
            {
                return null;
            }
            else if (word.Length == 0 || word.Length < 2)
            {
                return word;
            }

            char[] charArray = word.ToCharArray();
            int start = 0;
            int end = charArray.Length - 1;

            while (start < end)
            {
                if (!char.IsLetter(charArray[start]))
                {
                    start++;
                }
                else if (!char.IsLetter(charArray[end]))
                {
                    end--;
                }
                else
                {
                    char step = charArray[start];
                    charArray[start] = charArray[end];
                    charArray[end] = step;
                    start++;
                    end--;
                }
            }
            
            string result = new string(charArray);

            return result;
        }

        public static string Revers(string words)
        {
            if (words == null)
            {
                return null;
            }
            else if (words.Length == 0)
            {
                return words;
            }
            
            string[] stringArray = words.Split(' ');

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = ReverseWord(stringArray[i]);
            }

            string result = string.Join(" ", stringArray);

            return result;
        }
    }
}
