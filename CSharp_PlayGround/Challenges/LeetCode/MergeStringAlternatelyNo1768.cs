using System;
using System.Text;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //URL  
    class MergeStringAlternatelyClass
    {

        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
        //The time complexity is O(n), n= Max Length  word1 or word2 length
        public static string MergeStringAlternately(string word1, string word2)
        {
            //avoid stringbuilder internal array resizing
            StringBuilder strb = new StringBuilder(word1.Length + word2.Length);
            int maxLength = Math.Max(word1.Length, word2.Length);
            for (int i = 0; i < maxLength; i++) 
            {
                strb.Append(i < word1.Length ? word1[i] : "");
                strb.Append(i < word2.Length ? word2[i] : "");
            }
            return strb.ToString();
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static bool MergeStringAlternately_Final(string s)
        {
            return true;
        }

        public static void Implement()
        {            
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

        }

    }
}
