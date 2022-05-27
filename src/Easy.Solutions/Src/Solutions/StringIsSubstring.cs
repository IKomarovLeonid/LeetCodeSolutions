namespace Easy.Solutions.Solutions
{
    public class StringIsSubstring
    {
        /*
         *
         *Implement strStr().

        Given two strings needle and haystack, 
        return the index of the first occurrence of needle in haystack,
        or -1 if needle is not part of haystack.

               Clarification:

        What should we return when needle is an empty string? 
        This is a great question to ask during an interview.

        For the purpose of this problem, we will return 0 when needle is an empty string. 
        This is consistent to C's strstr() and Java's indexOf().
         *
         *
         *
         *
         *
         */


        public int StrStr(string haystack, string needle)
        {
            if (haystack == null || needle == null) return -1;
            if (haystack.Length < needle.Length) return -1;
            if (string.IsNullOrEmpty(needle) || string.Equals(haystack, needle)) return 0;

            var index = -1;

            for (var i = 0; i < haystack.Length && i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i] != needle[0]) continue;

                var j = i;
                index = i;
                var k = 0;

                while (k < needle.Length && j < haystack.Length)
                {
                    if (haystack[j] != needle[k])
                    {
                        index = -1;
                        break;
                    }
                    j++;
                    k++;
                }

                if (k == needle.Length) break;
            }

            return index;
        }
    }
}
