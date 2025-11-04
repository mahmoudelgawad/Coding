using System;
using System.Linq;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //URL   
    class RemoveElementClass
    {

        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
        public static int RemoveElement(int[] nums, int val)
        {
            //wrong answer because for just the arrange of elements
            if (nums.Length == 0) return 0;
            //# Select will just change each element to new form
            //var numsFiltered = nums.Select(e => e != val).ToArray();
            var numsFiltered = nums.Where(e => e != val).ToArray();
            numsFiltered.CopyTo(nums, 0);
            return nums.Length - numsFiltered.Length;
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static int RemoveElement_Final(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index] = nums[i];
                    ++index;
                }
            }
            return index;
        }

        public static void Implement()
        {          
            int[] nums = [3,2,2,3];
            Console.WriteLine(RemoveElement_Final(nums,3));

            nums = [5,9,5,12,3,5];
            Console.WriteLine(RemoveElement_Final(nums, 5));
        }

    }
}
