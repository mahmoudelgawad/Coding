using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //URL
    //IBM EG code examp 24 Oct 2025
    
    class GetErrorCodesTimestampsClass
    {
        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%

        //k = number of occurrences
        //t = size of the times window in seconds (last seconds)
        public static List<string> GetErrorCodesTimestamps(int k, int t, List<int> timestamps, List<string> errorCodes)
        {
            //1- search range in timestamps            
            int endTI = timestamps.Count - 1;
            int startTV = timestamps[endTI] - (t - 1);
            int startTI = timestamps.FindIndex(t => t >= startTV);

            var codes = errorCodes.GetRange(startTI, (endTI - startTI) + 1)
                .GroupBy(e => e)
                .Where(g => g.Count() == k)
                .Select(g => g.Key).ToList();
            
            return codes;
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static bool GetErrorCodesTimestamps_Final(string s)
        {
            return true;
        }

        public static void Implement()
        {
            var timestamps = new List<int>{ 100, 101, 102, 105, 110 };
            var errorCodes = new List<string>{"E1","E2","E1","E1","E2"};//E2,E1
            int k = 2;
            int t = 10;
            Console.WriteLine(string.Join(',',GetErrorCodesTimestamps(k,t, timestamps, errorCodes)));


            timestamps = new List<int> { 1, 2, 4, 5, 6, 7, 10};
            errorCodes = new List<string> { "E1", "E2", "E1", "E1", "E2", "E2", "E2"};//E2
            k = 3;
            t = 5;
            Console.WriteLine(string.Join(',', GetErrorCodesTimestamps(k, t, timestamps, errorCodes)));


            timestamps = new List<int> { 1, 2, 4, 5, 6};
            errorCodes = new List<string> { "E1", "E2", "E1", "E1", "E2"};//E1
            k = 2;
            t = 4;
            Console.WriteLine(string.Join(',', GetErrorCodesTimestamps(k, t, timestamps, errorCodes)));


            /*
              int start = DateTime.Now.Millisecond;
              Console.WriteLine(GetErrorCodesTimestamps_Final(haystack,needle));
              Console.WriteLine(DateTime.Now.Millisecond - start);  
             */
        }

    }
}
