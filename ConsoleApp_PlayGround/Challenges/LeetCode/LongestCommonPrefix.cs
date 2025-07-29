using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //https://leetcode.com/problems/longest-common-prefix/
    class LongestCommonPrefixClass
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) 
            {
                return "";
            }

            StringBuilder lcp = new StringBuilder();

            foreach (char ch in strs[0]) 
            {
                //here function going with each first starting array
                lcp.Append(ch);
            }

            return lcp.ToString();
        }
        public static int RomanToInt_Final(string s)
        {
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {              
                int currRn = GetIntFromRoman(s[i]);
                int prevRn = i == 0 ? 0 : GetIntFromRoman(s[i - 1]);
                num = currRn <= prevRn ? currRn + num : (currRn - prevRn) + (num - prevRn);
            }
            return num;        
        }

        private static int GetIntFromRoman(char roman) 
        {
            switch (roman) 
            {
                case 'I': return 1;
                case 'V': return 5; 
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }
        
        public static void Implement()
        {
            string s = "III";//3
            Console.WriteLine(RomanToInt_Final(s));
            s = "LVIII";//58
            Console.WriteLine(RomanToInt_Final(s));

            s = "MCMXCIV";//1994
            Console.WriteLine(RomanToInt_Final(s));

        }

    }
}
