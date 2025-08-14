using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //https://leetcode.com/problems/longest-common-prefix/
    class LongestCommonPrefixClass
    {

        //Runtime 9ms Beats 7.60%
        //Memory 44.34 MB Beats 13.92%
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) 
            {
                return "";
            }
       
            StringBuilder lcp = new StringBuilder();
            string smallestWord = strs.OrderBy(str => str.Length).ToArray().FirstOrDefault();

            for (int i = 0; i < smallestWord.Length; i++) 
            {
                char prevChar=' ';
                foreach (string str in strs) 
                {
                    if (char.IsWhiteSpace(prevChar))
                    {                       
                        prevChar = smallestWord[i];
                    }

                    if (str == smallestWord || prevChar == str[i])
                    {
                        continue;
                    }
                    else 
                    {
                        prevChar = ' ';
                        break;
                    }                
                }
                lcp.Append(char.IsWhiteSpace(prevChar) ? "" : prevChar);
                if (char.IsWhiteSpace(prevChar)) 
                {
                    break;
                }
            }

            return lcp.ToString();
        }

        //Runtime 1ms Beats 86.75%
        //Memory 43.84 MB Beats 22.19%
        public static string LongestCommonPrefix_Final(string[] strs)
        {
            //sorting by ASC ,then comparing first string with last string
            //ASC order [Flight,Flow,Flower], res= Fl
            if (strs == null || strs.Length == 0) return "";
            StringBuilder result = new StringBuilder();
            Array.Sort(strs);
            string first = strs[0], last = strs[strs.Length - 1];
            for (int i = 0; i < first.Length; i++) 
            {
                if (i < last.Length && first[i] == last[i])
                    result.Append(first[i]);
                else 
                    break;
            }
            return result.ToString();
        }
        
        public static void Implement()
        {
            string[] s = new string[] { "Flower", "Flow","Fligth" };//fl
            Console.WriteLine(LongestCommonPrefix_Final(s));
            
            s = new string[] { "dog", "racecar", "car" };//
            Console.WriteLine(LongestCommonPrefix_Final(s));

            s = new string[]{ "cir", "car" };//c
            Console.WriteLine(LongestCommonPrefix_Final(s));

            s = new string[] { "reflower", "flow", "flight" };//
            Console.Write(LongestCommonPrefix_Final(s));
        }

    }
}
