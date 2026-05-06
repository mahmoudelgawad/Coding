using System;
using System.Reflection;
using System.Text;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //URL
    //https://leetcode.com/problems/maximum-average-subarray-i/

    class MaximumAverageSubarrayClass
    {

        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
        private static double MaximumAverageSubarray(int[] nums, int k)
        {
            double maxAvg = 0.0d;
            double sum = 0.0d;

            for (int i = 0; i < k; i++) sum += nums[i];
            maxAvg = sum / k;
      

            for (int i = k; i < nums.Length; i++) 
            {
                sum += nums[i] - nums[i - k];
                maxAvg = Math.Max(maxAvg, sum / k);
            }
            return maxAvg;
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        private static bool MaximumAverageSubarray_Final(string s)
        {
            return true;
        }

        public static void Implement()
        {

             int[] nums = [1,12,-5,-6,50,3];
             int k = 4;

            double result = MaximumAverageSubarray(nums, k);
            string greenTrue = "\u001b[32mTRUE\u001b[0m", redFalse = "\u001b[31mFALSE\u001b[0m";
            StringBuilder mark = new StringBuilder(result == 12.75d ?  greenTrue: redFalse);
            Console.WriteLine($"result 1: {result}, {mark}");

            nums = [5];
            k = 1;
            result = MaximumAverageSubarray(nums, k);
            mark.Clear();
            mark.AppendLine(result == 5.0d ? greenTrue : redFalse);
            Console.WriteLine($"result 2: {result}, {mark}");
        }

    }
}
