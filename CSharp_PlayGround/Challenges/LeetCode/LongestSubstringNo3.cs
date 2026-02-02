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
            //but need to check after removed duplicates characters is match subsstring in original string
            //!!!

            return set.Count;
        }


        //optimum solution using algorithm "sliding window" using dictionary
        public static int LongestSubstring_Final(string s)
        {
            Dictionary<char, int> charIndex = new Dictionary<char, int>();
            int maxLength = 0;
            int left = 0;
            for (int right = 0; right < s.Length; right++) 
            {
                char currentChar = s[right];
                
                if(charIndex.ContainsKey(currentChar))
                    left = Math.Max(left, charIndex[currentChar] + 1);
                
                charIndex[currentChar] = right;

                maxLength = Math.Max(maxLength, right - left + 1);
            }
            return maxLength;
        }

        public static void Implement()
        {
             
             string s = "pwwkew";
             Console.WriteLine(LongestSubstring_Final(s));

            // s = "bbbbb";
            //Console.WriteLine(LongestSubstring_Final(s));



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
