﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;

namespace ArraysAndStrings
{
    public interface IChapter1
    {
        bool isPermutation(string s1, string s2);
        bool isUniqueString(string s);
        bool OneAway(string s1, string s2);
        bool PalindromePermutation(string s);
        string URLifyString(string s, int stringLength);
    }

    public class Chapter1 : IChapter1
    {
        public Boolean isUniqueString(string s)
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

        public Boolean isPermutation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            // Turn the two strings into Char arrays so we can process each string char by char checking for a permutation
            char[] s1Chars = s1.ToCharArray();
            char[] s2Chars = s2.ToCharArray();

            // By sorting the two arrays if there is a permutation they will contain the same chars
            Array.Sort(s1Chars);
            Array.Sort(s2Chars);

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1Chars[i] != s2Chars[i])
                    return false;
            }
            return true;
        }

        public string URLifyString(string s, int stringLength)
        {
            string URLifiedString = "";

            for (int i = 0; i < stringLength; i++)
            {
                if (s[i] == ' ')
                    URLifiedString += "%20";
                else
                    URLifiedString += s[i];
            }

            return URLifiedString;
        }

        public Boolean PalindromePermutation(string s)
        {
            //#106, #121, #134, #136
            //What characteristics would a string that is a permutation of a palindrome have
            //Have you tried a hash table? You should be able to get this down to 0(N) time.
            return false;
        }

        public Boolean OneAway(string s1, string s2)
        {
            if (s1.Equals(s2))
                return true;

            List<string> startingString;

            return false;
        }
    }
}
