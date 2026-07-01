using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp_PlayGround.Challenges.Other
{
    internal class ArrayChallenges
    {
        //#get duplicate numbers in Array

        public void GetDuplicates_Negative_FlibSign_Inplace_NotForALLCasesSolution(int[] arr) 
        {
            //#O(n)
            //#Not For ALL Cases Solution
            //#Special case — values in range [1, N], O(1)
            List<int> duplicated = new List<int>();
            for (int i = 0; i < arr.Length; i++) 
            {
                int index = Math.Abs(arr[i]) - 1;
                if (index > arr.Length - 1) continue;
                if (arr[index] < 0)
                {
                    duplicated.Add(Math.Abs(arr[i]));
                    //duplicated.Add(index +1);
                }
                else 
                {
                    arr[index] = -arr[index];
                }
            }
            Console.WriteLine(string.Join(',',duplicated));
        }

        //using sort list/array (modify) with for loop , O(N*LogN)
        public void GetDuplicateNumbers_Sort_InPlace(int[] arr) 
        {
            //#O(nlogn)
            List<int> duplicates = new List<int>();
            //#modify the original array !!
            Array.Sort(arr);
            for (int i=0; i<arr.Length -1; i++) 
            {
                if (arr[i] == arr[i + 1] && !duplicates.Contains(arr[i])) 
                {
                    duplicates.Add(arr[i]);
                }
            }
            Console.WriteLine(string.Join(',',duplicates));
        }


        public void GetDuplicateNumbers_Hashset_ISet_NOTCOMPLETED(int[] arr) 
        {
            //# using HashSet,avoid duplicate by default, best quick in get total count Duplicated numbers
            //#not complete solution you still need use loop O(n) also after
            HashSet<int> seenNums = new HashSet<int>(arr);
            List<int> douplicates =new List<int>();
          
            //Console.WriteLine(string.Join(',',douplicates));
        }


        public void GetDuplicateNumbers_BadTimeSolution()
        {
            //# bad code 01, it's using nested 'For Loop', O(N^2)

            //var ar = new int[9] {5,4,66,4,7,8,6,1,4};
            int[] arr = { 5, 4, 66, 4, 7, 8, 6, 1, 4, 66, 6 };
            List<int> doubleValues = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int ii = 0; ii < arr.Length; ++ii)
                {
                    if (arr[i] == arr[ii] && i != ii)
                    {
                        if (doubleValues.Contains(arr[i]))
                        {
                            break;
                        }
                        doubleValues.Add(arr[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(',', doubleValues.ToArray()));
        }


        //#return two indexes position in the array that equal total sum value 'n1+n2=total'
        //#using complement substraction equation and dictionary<value, index>
        public int[] FindNumbersIndexOfTotalSum(int[] arr, int total) 
        {
            //#using dictionary instead go multiple nested loop for each item in array
            Dictionary<int,int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++) 
            {
                int complement = total - arr[i];
                if (numbers.ContainsKey(complement)) 
                {
                    return new int[] { i, numbers[complement] };
                }
                else
                  numbers.Add(arr[i], i);
            }
            return new int[] { };
        }
    }

    public static class ArrayChallengesImplementation
    {
        public static void Implement() 
        {
            ArrayChallenges arrclass = new ArrayChallenges();
            var res = arrclass.FindNumbersIndexOfTotalSum(new int[] {45,2,12,60,10,5},12);

            //#doublicate numbers
            //# 1, 49, 5
            arrclass.GetDuplicateNumbers_Sort_InPlace([1, 49, 5, 6, 7, 49, 5, 16, 18, 1]);

            //#doublicate numbers
            //# result = 5
            arrclass.GetDuplicates_Negative_FlibSign_Inplace_NotForALLCasesSolution([5,3,2,5,9]);
            //# result = [1, 49, 5]
            arrclass.GetDuplicates_Negative_FlibSign_Inplace_NotForALLCasesSolution([1, 49, 5, 6, 7, 49, 5, 16, 18, 1]);

        }
    }
}
