using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Challenges.CoderByte
{
    internal class FirstReverseClass
    {
        public static string FirstReverse(string str)
        {
            // code goes here
             var arr = str.ToCharArray();
             Array.Reverse(arr);
             return string.Join("", arr);     
        }
        public static string FirstReverse_Final(string str) 
        {
            return string.Join("", str.ToCharArray().Reverse());
        }

        // keep this function call here
        public static void Implement()
        {

            Console.WriteLine(FirstReverse("mahmoud love javascript"));

        }
    }
}
