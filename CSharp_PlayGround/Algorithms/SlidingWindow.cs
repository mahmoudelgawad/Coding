using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp_PlayGround.Algorithms
{
    internal class SlidingWindow
    {
        //# first sliding window type is fixed size , and moving to right -> , (-) the old left elemnt and (+) the new right
        public static int MaxSumSubarray(int[] arr, int k)
        {
            int n = arr.Length;
            int maxSum = 0, windowSum = 0;

            // 1. Initial window sum
            for (int i = 0; i < k; i++) windowSum += arr[i];
            maxSum = windowSum;

            // 2. Slide the window
            for (int i = k; i < n; i++)
            {
                // Subtract the element that is left behind, add the new element
                windowSum += arr[i] - arr[i - k];
                maxSum = Math.Max(maxSum, windowSum);
            }
            return maxSum;
        }

        //# second sliding window type is fixed size then shrinking , and moving to right -> , (-) the old left elemnt and (+) the new right,
        //# then shrink to the remaining items
        //# need left variable
        public static int MinLengthSumSubarray(int[] arr, int s)
        {
            int len = arr.Length;
            int left = 0, windowSum = 0, maxSum = 0, minLength = 0;
            

            for(int i = 0; windowSum < s; i++)
            {
                windowSum += arr[i];
                minLength = i;
            }

            for (int right = minLength + 1; right < len; i++) 
            {
              
            }
            
            return errortodo;
        }

        public static int MinSubArrayLen(int target, int[] nums)
        {
            int n = nums.Length;
            int minLength = int.MaxValue;
            int currentSum = 0;
            int left = 0;

            for (int right = 0; right < n; right++)
            {
                // Expand window by adding elements from the right
                currentSum += nums[right];

                // Shrink window from the left while the condition is met
                while (currentSum >= target)
                {
                    minLength = Math.Min(minLength, right - left + 1);
                    currentSum -= nums[left];
                    left++;
                }
            }

            // Return 0 if no valid subarray was found
            return minLength == int.MaxValue ? 0 : minLength;
        }

        public static void Implement() 
        {
            //get maximum SUM sequence in Array
            int k = 3;
            int[] arr = { 1, 2, 6, 2, 4, 1 };
            int result = MaxSumSubarray(arr, 3);
            Console.WriteLine(result);

            /*
            int[] arr = { 2, 3, 1, 2, 4, 3 };
            int s = 7;
            Console.WriteLine(MinSubArrayLen(s, arr)); // Output: 2
            */
        }
    }
}
