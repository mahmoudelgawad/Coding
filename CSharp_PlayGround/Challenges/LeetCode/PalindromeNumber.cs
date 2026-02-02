using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
   //https://leetcode.com/problems/palindrome-number/description/
    class PlaindromeNumberClass
    {
        public static bool IsPalindrome(int x)
        {
            if ( !(Math.Pow(-2,31) <= x) || !(x <= Math.Pow(2, 31)-1) ) 
            {
                return false;
            }
            char[] arrA = x.ToString().ToArray();
            char[] arrB = new char[arrA.Length]; 

            arrA.CopyTo(arrB, 0);
            Array.Reverse(arrB);

            for (int i = 0; i < arrA.Length; i++) 
            {
                if (arrA[i] != arrB[i]) 
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsPalindrome_Final(int x)
        {
            int reverse = 0, copy = x;
            while (copy > 0) 
            {
                reverse = reverse * 10 + copy % 10;
                copy /= 10;
            }
            return reverse == x;  
        }

        
        public static void Implement()
        {
            int num = 121;//true
            Console.WriteLine(IsPalindrome_Final(num));
             num = -121;//false
            Console.WriteLine(IsPalindrome_Final(num));

            num = 242;//true
            Console.WriteLine(IsPalindrome_Final(num));




        }

    }
}
