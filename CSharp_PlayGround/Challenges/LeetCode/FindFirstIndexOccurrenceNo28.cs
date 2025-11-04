using System;

namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/solutions/4749634/beats-100-with-this-easy-solution-in-java-python-c-c/

    class FindFirstIndexOccurrenceClass
    {       
        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
        public static int FindFirstIndexOccurrence(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static int FindFirstIndexOccurrence_Final(string haystack, string needle)
        {
            //#for '<=' to when length = 1 for both haystak and needle
            //# 'haystack.Length - needle.Length' for avoid last index in haystack + needle.Length not exist
            for (int i = 0; i <= haystack.Length - needle.Length; i++) 
            {
                if (haystack.Substring(i, needle.Length) == needle) 
                {
                    return i;
                }
            }
            return -1;
        }

        public static void Implement()
        {           
            string haystack = "AllahAkbarKabera";
            string needle = "Kaber";
            int start = DateTime.Now.Millisecond;
            Console.WriteLine(FindFirstIndexOccurrence_Final(haystack,needle));
            Console.WriteLine(DateTime.Now.Millisecond - start);
            /*
             s = "()";
             Console.WriteLine(MergeTwoSortedList(s));
            */
        }
    }
}
