using System;
namespace Easy.Solutions.Src.Solutions
{
    public class DetectCapital_520
    {
        /*
         * 
         * We define the usage of capitals in a word to be right when one of the following cases holds:

           All letters in this word are capitals, like "USA".
           All letters in this word are not capitals, like "leetcode".
           Only the first letter in this word is capital, like "Google".
           Given a string word, return true if the usage of capitals in it is right.
         * 
         */

        public bool DetectCapitalUse(string word)
        {
            var data = word;
            if (data.ToUpper() == word || data.ToLower() == word) return true;

            if (Char.ToUpper(data[0]) == word[0] &&
               data.Substring(1).ToLower() == word.Substring(1)) return true;

            return false;
        }
    }
}
