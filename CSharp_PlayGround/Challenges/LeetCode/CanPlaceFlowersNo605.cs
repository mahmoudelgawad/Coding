using System;
using System.Reflection;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //URL
    //https://leetcode.com/problems/can-place-flowers/

    class CanPlaceFlowersClass
    {
        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
        private static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            
            if(n < 0 || flowerbed.Length == 0) return false;
			int av=0;
			for(int i = 0; i < flowerbed.Length; i++)
			if(i%2 ==0 && flowerbed[i] == 0)
			   if(i == 0 && flowerbed[i+1] !=1 || i == flowerbed.Length-1 && flowerbed[i-1] != 1)		
				if( (i>0 && flowerbed[i-1] != 1) && (i<flowerbed.Length-1 && flowerbed[i+1] !=1))
					++av;
			return av >= n;
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        private static bool CanPlaceFlowers_Final(string s)
        {
            return true;
        }

        public static void Implement()
        {
            throw new NotImplementedException($"{MethodBase.GetCurrentMethod().DeclaringType.Name} Not Solved Yet");
            /* 
             string s = "({})";
             Console.WriteLine(CanPlaceFlowers(s));

             s = "()";
             Console.WriteLine(CanPlaceFlowers(s));
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
              Console.WriteLine(CanPlaceFlowers_Final(haystack,needle));
              Console.WriteLine(DateTime.Now.Millisecond - start);  
             */
        }

    }
}
