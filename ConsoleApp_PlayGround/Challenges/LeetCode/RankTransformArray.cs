using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //https://leetcode.com/problems/rank-transform-of-an-array/description/
    internal class RankTransformArray
    {
        public int[] Solution1(int[] arr)
        {
            if (arr.Length > 100000)
            {
                return arr;
            }
            int[] tempArr = new int[arr.Length];
            Array.Copy(arr, tempArr, arr.Length);
            tempArr = RemoveDublicateItems(tempArr);
            Array.Sort(tempArr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 1000000000)
                {
                    continue;
                }
                arr[i] = Array.IndexOf(tempArr, arr[i]) + 1;
            }

            return arr;
        }

        public int[] RemoveDublicateItems(int[] arr)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!temp.Contains(arr[i]))
                    temp.Add(arr[i]);
            }
            return temp.ToArray();
        }

        //best
        public int[] Solution2(int[] arr)
        {
            Dictionary<int, int> ranked = new Dictionary<int, int>();
            foreach (var item in arr.Order())
            {
                ranked.TryAdd(item, ranked.Count + 1);
            }
            return Array.ConvertAll(arr, item => ranked[item]);
        }


    }

    public class RankTransformArrayImplemntation
    {
        public static void Implement()
        {
            var arrSort = new RankTransformArray();
            int[] test = { 40, 10, 20, 30 };
            var result = arrSort.Solution1(test);
            Console.WriteLine(string.Join(",", result));

            //result = arrSort.ArrayRankTransform(new int[]{ 100,100,100});
            //Console.WriteLine(String.Join(",", result));

            //result = arrSort.ArrayRankTransform(new int[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 });
            //Console.WriteLine(String.Join(",", result));

            //better berformacne
            result = arrSort.Solution2(new int[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 });
            Console.WriteLine(string.Join(",", result));
        }
    }
}
