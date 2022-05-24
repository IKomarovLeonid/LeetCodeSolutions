using System;
namespace Easy.Solutions.Src.Solutions
{
    public class PercentageOfLetter_2278
    {
        public int PercentageLetter(string s, char letter)
        {
            var count = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == letter) count++;
            }
            return count * 100 / s.Length;
        }
    }
}
