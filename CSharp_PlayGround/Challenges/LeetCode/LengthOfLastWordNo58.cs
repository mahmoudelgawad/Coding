using System;
using System.Linq;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //URL
    //https://leetcode.com/problems/length-of-last-word/description/

    class LengthOfLastWordClass
    {
        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
        public static int LengthOfLastWord(string s)
        {
            //# 'Split()' return each space as single empty string ""
            string[] arr = s.Split(' ');
            string lastWord = arr.LastOrDefault(x => !string.IsNullOrEmpty(x));
            return string.IsNullOrEmpty(lastWord) ?0 :lastWord.Length ;
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static int LengthOfLastWord_Final(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            s = s.Trim();
            string[] arr = s.Split(' ');
            return arr[arr.Length - 1].Length;
        }

        public static void Implement()
        {
            int start = DateTime.Now.Millisecond;
            /*
             string s = "Mahmoud Ahmed";
             Console.WriteLine(LengthOfLastWord(s));//5
            */
             string s = "  stop fire  ";
             Console.WriteLine(LengthOfLastWord(s));//4
            Console.WriteLine(DateTime.Now.Millisecond - start);


            
              start = DateTime.Now.Millisecond;
              Console.WriteLine(LengthOfLastWord_Final(s));//4
              Console.WriteLine(DateTime.Now.Millisecond - start);  
            
        }

    }
}
