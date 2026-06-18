using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp_PlayGround.Challenges.Other
{
    internal class ArrayChallenges
    {
        //#get duplicate numbers in Array


        //using list with for loop O(n), asking it contains value before add number
        

        //# using HashSet,avoid duplicate by default, but just best in get total count douplicated numbers
        public void GetDouplicateNumbers_Hashset_ISet_Linq_NOTCOMPLETED(int[] arr) 
        {
            //#not complete solution you need use loop O(n) also  
            HashSet<int> uniqueNums = new HashSet<int>(arr);
            var doubleNums = arr.Where(n => !uniqueNums.Contains(n)).ToList();
            Console.WriteLine(string.Join(',',doubleNums));
        }

        public void GetDouplicateNumbers_BadCode01()
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


        //#return two numbers index position in the array that equal total sum value 'n1+n2=total'
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
            arrclass.GetDouplicateNumbers_Hashset_ISet_Linq([1, 49, 5, 6, 7, 49, 5, 16, 18, 1]);


        }
    }
}
