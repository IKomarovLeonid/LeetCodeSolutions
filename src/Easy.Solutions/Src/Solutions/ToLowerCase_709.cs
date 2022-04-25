namespace Easy.Solutions.Solutions
{

    public class ToLowerCase_709
    {
        // Task: Implement function ToLowerCase() that has a string parameter str, and returns the same string in lowercase.

        public string ToLowerCase(string str)
        {

            char[] strArray = str.ToCharArray();

            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i] < 91 && strArray[i] > 64)
                {
                    strArray[i] = (char)(strArray[i] + 32);
                }
            }

            return new string(strArray);
        }
    }
}
