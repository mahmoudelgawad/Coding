using System;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //https://leetcode.com/problems/search-insert-position/


    class SearchInsertPositionClass
    {
        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
        public static int SearchInsertPosition(int[] nums, int target)
        {
            int index = Array.IndexOf(nums, target);
            if (index > -1) return index;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > target) return i;
            }
            return nums.Length;
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static int SearchInsertPosition_Final(int[] nums, int target)
        {
            //also can inheance search using Binary search with middle value
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) return i;
                if (nums[i] > target) return i;
            }
            return nums.Length;
        }

        public static int SearchInsertPosition_Final2(int[] nums, int target)
        {
            int mid = (int)Math.Floor(nums.Length / 2d);
            mid = target < nums[mid] ? 0 : mid; 
            for (int i = mid; i < nums.Length; i++)
            {
                if (nums[i] >= target) return i;
            }
            return nums.Length;
        }

        public static void Implement()
        {
            int[] nums = [1, 2, 3, 4, 5, 6]; int target = 4; //3
            //int[] nums = [1, 2, 3, 4, 5, 6]; int target = 7; //6
            int start = DateTime.Now.Millisecond;
            Console.WriteLine(SearchInsertPosition_Final(nums, target));
            Console.WriteLine(DateTime.Now.Millisecond - start);

            start = DateTime.Now.Millisecond;
            Console.WriteLine(SearchInsertPosition_Final2(nums, target));
            Console.WriteLine(DateTime.Now.Millisecond - start);

            /*
            nums = [1, 2, 3, 4, 5, 6]; target = 7; //6
            Console.WriteLine(SearchInsertPosition_Final2(nums, target));
            */
        }

    }
}
