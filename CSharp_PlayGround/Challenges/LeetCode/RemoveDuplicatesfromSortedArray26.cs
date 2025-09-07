using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //URL
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
    
    class RemoveDuplicatesfromSortedArray
    {

        //Runtime 16ms Beats 0%
        //Memory 51.7MB Beats 0%
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            HashSet<int> uniqnums = new HashSet<int>(nums);
            //# also there SortedSet<int> for sort item's ASC by default
            for (int i = 0; i < uniqnums.Count; i++) 
            {
                nums[i] = uniqnums.ElementAt(i);
            }
            return uniqnums.Count;
        }


        //Runtime 1ms Beats 100%
        //Memory 51,46 MB Beats 18.3%
        public static int RemoveDuplicates_Final(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int k = 0;
            for (int i = 1; i < nums.Length; i++) 
            {
                if (nums[k] != nums[i])
                    nums[++k] = nums[i];
            }
            return k+1; 
            /*for (int i = 0; i < nums.Length; i++) 
            {
                for (int ii = 1; ii < nums.Length; ii++) 
                {
                    if (nums[i] != nums[ii])
                        nums[++i] = nums[ii];
                }             
            }
            return 0;*/
        }

        public static void Implement()
        {
            
            int[] a = [4,4,4,5,5,9,9,10,10,10,7,7];
            Console.WriteLine(RemoveDuplicates_Final(a)); //5

            a = [1,1,2];
            Console.WriteLine(RemoveDuplicates_Final(a)); //2
           
        }

    }
}
