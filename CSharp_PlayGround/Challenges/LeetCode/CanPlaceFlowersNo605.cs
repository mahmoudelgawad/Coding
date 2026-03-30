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
        private static bool CanPlaceFlowers_Final(int[] flowerbed, int n)
        {
            if (n < 0 || flowerbed.Length == 0) return false;
            int av = 0;
            for (int i = 0; i < flowerbed.Length; i++)
                if (flowerbed[i] == 0 &&
                    (
                     (i == 0 && i == flowerbed.Length-1) || //only one
                     (i == 0 && flowerbed[i + 1] == 0) || //left
                     (i == flowerbed.Length - 1 && flowerbed[i - 1] == 0) || //rigth
                     (i!= 0 && i!=flowerbed.Length-1 && flowerbed[i + 1] == 0 && flowerbed[i - 1] == 0) //middle
                    )
                   )
                {
                    ++av;
                    flowerbed[i] = 1;
                }
            return av >= n;
        }

        public static void Implement()
        {

            int[] flowerbed = [1,0,0,0,0,1];
            bool correctOutput = false;
            bool result = CanPlaceFlowers_Final(flowerbed,2);
            Console.WriteLine($"{result} , ({(correctOutput == result ? "\u221A" : "X")})");


            flowerbed = [0];
            result = CanPlaceFlowers_Final(flowerbed, 1);
            correctOutput = true;
            Console.WriteLine($"{result} , ({(correctOutput == result ? "\u221A" : "X")})");

            flowerbed = [1];
            result = CanPlaceFlowers_Final(flowerbed, 0);
            correctOutput = true;
            Console.WriteLine($"{result} , ({(correctOutput == result ? "\u221A" : "X")})");

            flowerbed = [0,1,0];
            result = CanPlaceFlowers_Final(flowerbed, 1);
            correctOutput = false;
            Console.WriteLine($"{result} , ({(correctOutput == result ? "\u221A" : "X")})");


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
