using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //URL

    //#shift zero integer to the end of the array,other values shift to start of the array
    class MoveZeorsClass
    {
        private static void MoveZeors_NotAccepted(int[] nums)
        {
            //# not aceepted, not allowed copy to new array
            if (nums.Length <= 1) return;
            int[] newArr = new int[nums.Length];
            int end = nums.Length - 1;
            int start = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    //#move to the end
                    newArr[end--] = nums[i];
                }
                else
                {
                    //#move to start
                    newArr[start++] = nums[i];
                }
            }
            Console.WriteLine(string.Join(',', newArr));

        }

        //# using waterflall algorithm (increment number) during O(n) length.
        //# then (watterfall - currentIndex) to shift/move non-zeros
        public static void MoveZeors(int[] nums)
        {
            if (nums.Length <= 1) return;
            int zerosCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    ++zerosCount;
                else if (zerosCount > 0)
                {
                    int tempNonZero = nums[i];
                    nums[i - zerosCount] = tempNonZero;
                    nums[i] = 0;
                }
            }
            Console.WriteLine(string.Join(',', nums));
        }

        public static void Implement()
        {
            Action<int[]> selectedMethod = nums => MoveZeors(nums);
            
            int[] arr = [0, 1, 0, 3, 12];  
            selectedMethod(arr);

            arr = new int[] { 1, 9, 10, 0, 12, 13 };
            selectedMethod(arr);

            arr = new int[] { 0 };
            selectedMethod(arr);

            arr = new int[] { 1, 0 };
            selectedMethod(arr);
        }

    }
}
