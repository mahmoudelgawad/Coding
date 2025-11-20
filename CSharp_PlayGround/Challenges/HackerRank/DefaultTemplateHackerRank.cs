using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //URL
    //https://www.hackerrank.com/challenges/diagonal-difference/problem?isFullScreen=true

    class DefaultTemplateHackerRankClass
    {

        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
        public static int DefaultTemplateHackerRank(string s)
        {
            return 0;
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static bool DefaultTemplateHackerRank_Final(string s)
        {
            return true;
        }

        private void MainImplment() 
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DefaultTemplateHackerRank("");

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
            textWriter.Close();
            textWriter.Close();
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
