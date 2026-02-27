using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //URL
	//https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/description/?envType=study-plan-v2&envId=leetcode-75
    
    class GreatestKidsCandiesClass
    {
        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = candies.Max();
            //# instead of three steps
            //  1-define temp list<boo>
            //  2-for loop on [candies]
            //  3-return the result
            return candies.Select(c => c + extraCandies >= max).ToList();
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static IList<bool> KidsWithCandies_Final(int[] candies, int extraCandies)
        {
            return null;
        }

        public static void Implement()
        {
            /* 
             string s = "({})";
             Console.WriteLine(DefaulTemplateLeetCode(s));

             s = "()";
             Console.WriteLine(DefaulTemplateLeetCode(s));
            */

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
              Console.WriteLine(DefaulTemplateLeetCode_Final(haystack,needle));
              Console.WriteLine(DateTime.Now.Millisecond - start);  
             */
        }

    }
}
