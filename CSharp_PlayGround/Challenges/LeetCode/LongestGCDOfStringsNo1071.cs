using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //URL
    //https://leetcode.com/problems/greatest-common-divisor-of-strings/description/?envType=study-plan-v2&envId=leetcode-75

    public record resultRecord(string Result,bool isPass);
    class LongestGCDOfStringsClass
    {

        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
        public static string LongestGCDOfStrings(string str1, string str2)
        {
            //# not found math GCD in c#
            //Math.gcd
            if (str1 + str2 != str2 + str1)
                return "";
            int n = GCD(str1.Length ,str2.Length);
            return str1.Substring(0,n);
        }

        private static int GCD(int n1, int n2) 
        {
            while (n1 != 0 && n2 != 0) 
            {
                if (n1 > n2)
                    n1 %= n2;
                else
                    n2 %= n1;
            }
            return n1 | n2;
        }

        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static string LongestGCDOfStrings_Final(string str1, string str2)
        {
            return LongestGCDOfStrings(str1, str2);
        }

        public static void Implement()
        {
            string str1 = "TAUXXTAUXXTAUXXTAUXXTAUXX";
            string str2 = "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX";
            string output = "TAUXX";
            string result = LongestGCDOfStrings(str1, str2);

            //# inline anonymous type
            //var data = new { Result = result, isPass = result == outputstr };

            //# immutable record object
            var data = new resultRecord(result, result == output);

            Console.WriteLine(data.ToString());
            
        }

    }
}
