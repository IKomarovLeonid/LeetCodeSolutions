using System;

namespace Medium.Solutions.Solutions
{
    public class StringtoIntegerAtoi_8
    {
        // Task:
        // Implement atoi which converts a string to an integer.
        // The function first discards as many whitespace characters as necessary until the first non-whitespace character is found. Then, starting from this character, takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.
        // The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.
        // If the first sequence of non-whitespace characters in str is not a valid integral number, or if no such sequence exists because either str is empty or it contains only whitespace characters, no conversion is performed.
        // If no valid conversion could be performed, a zero value is returned.

        public int MyAtoi(string str)
        {
            for (int j = 0; j < str.Length - 1; j++)
            {
                if (str[j] != ' ')
                {
                    if (str[j] == '+' && (str[j + 1] < 48 || str[j + 1] > 57)) return 0; // if this is a not digit 
                    else
                    {
                        if (str[j + 1] == '+') break;
                    }
                }

                else continue;
            }
            string output = null;
            for (int i = 0; i < str.Length; i++)
            {
                if (output == null)
                {
                    if (str[i] != ' ' && str[i] != '+')
                    {
                        if (str[i] > 47 && str[i] < 58)
                        {
                            output += str[i];  // add to rezult string if we have digit 
                        }
                        else
                        {
                            if (str[i] == '-')
                            {
                                output += str[i];
                            }
                            else break;
                        }

                    }
                    else continue;
                }
                else
                {
                    if (str[i] > 47 && str[i] < 58)
                    {
                        output += str[i];
                    }
                    else break;
                }

            }
            if (output == null) return 0;
            if (output.Length == 1 && output[0] == '-') return 0;
            int rezult = 0;
            bool flag = int.TryParse(output, out rezult); // check for overflow 
            if (flag == false)
            {
                if (output[0] == '-') return -2147483648;
                else return 2147483647;
            }
            else
            {
                rezult = Convert.ToInt32(output);
            }
            return rezult;
        }
    }
}
