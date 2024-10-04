using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    internal class TwoSum
    {
        //https://leetcode.com/problems/two-sum/
        public int[] Solution1(int[] nums, int target) 
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int ii = i + 1; ii < nums.Length; ii++)
                {
                    if (nums[i] + nums[ii] == target)
                    {
                        return new int[] { i, ii };
                    }
                }
            }
            return new int[]{ };
        }

        //best
        public int[] Solution2(int[] nums, int target)
        {
            Dictionary<int, int> dicValueIndex = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) 
            {
                if (dicValueIndex.ContainsKey(target - nums[i]))
                    return new int[] { dicValueIndex[target - nums[i]], i };
                else
                    dicValueIndex.TryAdd(nums[i], i);               
            }
            return new int[] { };
        }
    }

    public class TwoSumImplementation 
    {
        public static void Implement() 
        {
            TwoSum twoSum = new TwoSum();
           var result =  twoSum.Solution2(new int[] { 2, 5, 7, 3 }, 9);
            Console.WriteLine($"[{String.Join(',',result)}]");

        }
    }
}
