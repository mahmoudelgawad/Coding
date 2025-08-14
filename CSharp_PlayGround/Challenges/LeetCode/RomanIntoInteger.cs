using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //https://leetcode.com/problems/palindrome-number/description/
    //https://leetcode.com/problems/roman-to-integer/solutions/1362651/c-runtime-94-and-memory-98-o-n/
    //https://leetcode.com/problems/roman-to-integer/solutions/5848685/video-looping-two-characters-at-a-time/
    class RomanToIntegerClass
    {
        public static int RomanToInt(string s)
        {
            int num = 0;
            Dictionary<char, int> romanNumbers = new Dictionary<char, int> {
                {'I',1 },
                {'V',5 },
                {'X',10},
                {'L',50 },
                {'C',100},
                {'D',500},
                {'M',1000}                
            };

            for (int i =0; i < s.Length; i++ ) 
            {
               // if ch duplicated, will return same first index number, s.IndexOf(ch)
               int currRn = romanNumbers.FirstOrDefault(vp => vp.Key == s[i]).Value;
               int prevRn = i == 0 ? 0 : romanNumbers.FirstOrDefault(vp => vp.Key == s[i - 1]).Value;
               num = currRn <= prevRn ? currRn + num : (currRn - prevRn)+(num-prevRn); 
            }
            return num;
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
