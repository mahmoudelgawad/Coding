using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //URL
    //https://www.hackerrank.com/challenges/diagonal-difference/problem?isFullScreen=true

    class DiagonalDifferenceClass
    {
        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int totalL = 0;
            int totalR = 0;
            int r = 0;
            for (int m = 0; m <= arr.Count - 1; m++)
            {
                r = arr[m].Count - 1 - m;
                totalL += arr[m][m];
                totalR += arr[m][r];
            }
            int diff = (totalR - totalL);
            return diff < 0 ? diff * -1 : diff;
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static bool DiagonalDifference_Final(string s)
        {
            return true;
        }

        private void MainImplment()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            //int result = DiagonalDifference("");
            int result = 0;

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
            textWriter.Close();
            textWriter.Close();
        }
        public static void Implement()
        {
            //List<int> l = new List<int>{ 1, 2, 3, };
            List<List<int>> arr = new List<List<int>> {
                 new List<int> {1,2,3},
                 new List<int> {4,5,6},
                 new List<int> {9,8,9}};
            Console.WriteLine(DiagonalDifference(arr));

            arr = new List<List<int>> {
                 new List<int> {11,2,4},
                 new List<int> {4,5,6},
                 new List<int> {10,8,-12}};
            Console.WriteLine(DiagonalDifference(arr));  
        }

    }
}
