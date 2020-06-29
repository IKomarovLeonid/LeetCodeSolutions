namespace Medium.Solutions.Src.Solutions
{
    public class LongestSubstringWithoutRepeatingCharacters_3
    {
        // Task:
        // Given a string, find the length of the longest substring without repeating characters.

        public int LengthOfLongestSubstring(string s)
        {

            string output = null; // rezult string of  function 
            int outn = 0; // rezult of function 
            for (int i = 0; i < s.Length; i++)
            {
                output += s[i];
                int j = i + 1;

                while (j < s.Length)
                {
                    if (!output.Contains(s[j]))
                    {
                        output += s[j];
                    }
                    else
                    {
                        break;
                    }
                    j++;
                }
                if (output.Length > outn)
                {
                    outn = output.Length;
                }
                output = null;
            }
            return outn;
        }
    }
}
