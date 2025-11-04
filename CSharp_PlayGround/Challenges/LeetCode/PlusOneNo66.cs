using System;
using System.Collections.Generic;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //URL
    //https://leetcode.com/problems/plus-one/description/

    //# if you want to cut any digit number to small pieces/numbers divid by 10
    //# 199/10 = 19.9, so use (%) division remainder (modulo operator)
    //# to get [9]
    class PlusOneClass
    {
        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
        public static int[] PlusOne(int[] digits)
        {
           string strNum= String.Join("", digits);
           long num = 0;
           if (!long.TryParse(strNum, out num)) return new int[] {0};
           ++num;
           Stack<int> lsk = new Stack<int>();
           while (num > 0) 
           {
               lsk.Push((int)(num % 10));
               num = num / 10;
           }
           return lsk.ToArray();
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static bool PlusOne_Final(string s)
        {
            return true;
        }

        public static void Implement()
        {
            int[] s = { 1, 9, 9 };
            Console.WriteLine(string.Join("", PlusOne(s)));

            s = new int[] { 2, 1, 9 };
            Console.WriteLine(string.Join("", PlusOne(s)));

            s = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            Console.WriteLine(string.Join("",PlusOne(s)));

            /*
              int start = DateTime.Now.Millisecond;
              Console.WriteLine(PlusOne_Final(haystack,needle));
              Console.WriteLine(DateTime.Now.Millisecond - start);  
             */
        }

    }
}
