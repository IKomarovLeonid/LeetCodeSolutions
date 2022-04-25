namespace Easy.Solutions.Solutions
{
    internal class LongestCommonPrefix_14
    {
        /*
         * Write a function to find the longest common prefix string amongst an array of strings.

           If there is no common prefix, return an empty string "".
         */


        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1) return strs[0];

            var prefix = string.Empty;
            var isDone = false;

            for (var i = 0; i < strs[0].Length && !isDone; i++)
            {
                var symbol = strs[0][i];

                for (var index = 1; index < strs.Length; index++)
                {
                    // check
                    var len = strs[index].Length;
                    if (i >= len)
                    {
                        isDone = true;
                        break;
                    }

                    if (strs[index][i] == symbol) continue;

                    isDone = true;
                    break;
                }

                if (!isDone) prefix += strs[0][i];
            }

            return prefix;
        }
    }
}
