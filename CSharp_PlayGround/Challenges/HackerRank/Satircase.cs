using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //URL
    //https://www.hackerrank.com/challenges/staircase/problem?isFullScreen=true

    class StaircaseClass
    {

        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
         public static void staircase(int n)
		 { 
			for(int i =0;i<n;i++)
			{
				int spaces = n - i - 1;
				int chars = i + 1;
				Console.WriteLine(new String(' ',spaces) + new string('#',chars));  
			}
		 }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static bool DefaultTemplateHackerRank_Final(string s)
        {
            return true;
        }

        public static void Implement()
        {
            /* 
             string s = "({})";
             Console.WriteLine(DefaultTemplateHackerRank(s));

             s = "()";
             Console.WriteLine(DefaultTemplateHackerRank(s));
            */


            /*
              int start = DateTime.Now.Millisecond;
              Console.WriteLine(DefaultTemplateHackerRank_Final(haystack,needle));
              Console.WriteLine(DateTime.Now.Millisecond - start);  
             */
        }

    }
}
