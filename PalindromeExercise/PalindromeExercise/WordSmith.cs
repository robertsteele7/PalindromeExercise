using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }

            //reverse the word
            if (reversed.ToLower() == word.ToLower())
            {
                return true;
            }
            else 
            {
                return false;
            }
            //compare the original with the reversed

            //return whether they are the same or not
        }
    }
}
