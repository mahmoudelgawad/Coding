using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //URL
    //https://leetcode.com/problems/longest-substring-without-repeating-characters

    class LongestSubstringClass
    {
        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
        public static int LongestSubstring(string s)
        {
            HashSet<char> set = new HashSet<char>(s);
            

            return set.Count;
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static bool LongestSubstring_Final(string s)
        {
            return true;
        }

        public static void Implement()
        {
             
             string s = "wwkewp";
             Console.WriteLine(LongestSubstring(s));

             s = "bbbbb";
            Console.WriteLine(LongestSubstring(s));



            /*
            string word1 = "abc";
            string word2 = "pqr";
            string output = "apbqcr";
            string result = MergeStringAlternately(word1, word2);
            Console.WriteLine($"{result} , {result == output}");

            word1 = "ab";
            word2 = "pqrs";
            output = "apbqrs";
            result = MergeStringAlternately(word1, word2);
            Console.WriteLine($"{result} , {result == output}");

            word1 = "abcd";
            word2 = "pq";
            output = "apbqcd";
            result = MergeStringAlternately(word1, word2);
            Console.WriteLine($"{result} , {result == output}");
             */

            /*
              int start = DateTime.Now.Millisecond;
              Console.WriteLine(LongestSubstring_Final(haystack,needle));
              Console.WriteLine(DateTime.Now.Millisecond - start);  
             */
        }

    }
}
