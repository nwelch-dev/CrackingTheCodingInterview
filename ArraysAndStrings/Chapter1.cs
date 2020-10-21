using System;

namespace ArraysAndStrings
{
    public static class Chapter1
    {
        public static Boolean isUniqueString(string s)
        {
            if (s.Length < 1)
                return false;

            char currentChar;

            // If the string is not unique, return false
            for (int i = 0; i < s.Length; i++)
            {
                currentChar = s[i];
                for (int j = 0; j < s.Length; j++)
                {
                    if (j != i && currentChar == s[j])
                        return false;
                }
            }
            return true;
        }

        public static Boolean isPermuation(string s1, string s2)
        {
            for (int i = 0; i < s1.Length; i++)
            {
            }
            return false;
        }
    }
}
