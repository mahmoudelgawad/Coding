using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp_PlayGround.Challenges.CoderByte
{
    class FindIntersectionClass
    {
        public static string FindIntersection(string[] strArr)
        {
            if (strArr.Length == 0)
            {
                return "false";
            }
            List<int?> intercepts = null;
            //smallest list
            int smallLstIndex = strArr[0].Length > strArr[1].Length ? 0 : 1;
            int bigLstIndex = smallLstIndex == 0 ? 1 : 0;

            //get separated values
            var numSmallLst = strArr[smallLstIndex].Replace(" ", "").Split(",")
            .Select(s => int.TryParse(s, out int n) ? n : (int?)null)
            .ToList();

            var numBigLst = strArr[bigLstIndex].Replace(" ", "").Split(",")
            .Select(s => int.TryParse(s, out int n) ? n : (int?)null)
            .ToList();

            //comparring
            foreach (int? n in numSmallLst)
            {
                if (n == null)
                    continue;

                if (numBigLst.Contains(n))
                {
                    if (intercepts == null) 
                    {
                        intercepts = new List<int?>();
                    }
                        
                    if (intercepts.Contains(n)) 
                    {
                        continue;
                    }

                    intercepts.Add(n);
                }
            }

            // code goes here  
            return intercepts != null ? string.Join(",", intercepts) : "false";

        }
        public static string FindIntersection_Final(string[] StrArr)
        {
            if (StrArr.Length == 0) 
            {
                return "false";
            }
            string intercepts = string.Join(",",
                              StrArr[0].Split(",").Select(s => s.Replace(" ", ""))
                             .Intersect(StrArr[1].Split(",").Select(s => s.Replace(" ", ""))));
            return string.IsNullOrEmpty(intercepts) ? "false" : intercepts;
        }
     
        public static void Implement()
        {
            //string str = "#" + "  mahmoud ahmed, 15, 6  9, 20   ".Replace(" ", "") + "#";
            string[] arr = { "15,15, 6, 5 9,14,70, 87", "6,3,5,87, 15 , 7, 7 0" };
            Console.WriteLine(FindIntersection(arr));
            Console.WriteLine(FindIntersection_Final(arr));

            //empty array
            arr =new string[] { };
            Console.WriteLine(FindIntersection(arr));
            Console.WriteLine(FindIntersection_Final(arr));

            //empty array
            arr = new string[] { "",""};
            Console.WriteLine(FindIntersection(arr));
            Console.WriteLine(FindIntersection_Final(arr));

            // Console.WriteLine(FindIntersection(Console.ReadLine()));
        }

    }

}