using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Challenges.Other
{
    internal class ArrayChallenges
    {
        //get duplicate numbers in Array
        //mehtod 1, using list, asking it contains value before add number
        //method 2, best practis i think using Set 
        public static void GetDouplicateNumbers()
        {
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

        }
    }
}
