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
            
        }

    }
}
