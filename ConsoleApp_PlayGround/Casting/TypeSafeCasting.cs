using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Casting
{
    internal class TypeSafeCasting
    {
        public static void Implement() 
        {
            //test type safe casting
            int num = 5;
            string str = "5";
            //int res = num + str; // ERROR can not implicit convert string to int
            //string res = num + str; // OK 
            var res = num + str; // OK , will make res as string by default
            Console.WriteLine(res);
        }
    }
}
