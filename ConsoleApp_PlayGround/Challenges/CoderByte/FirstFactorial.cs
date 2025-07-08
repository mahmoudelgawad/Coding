using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Challenges.CoderByte
{
    internal class FirstFactorialClass
    {
        public static int FirstFactorial_Final(int num) 
        {
            if (num <= 0) 
            {
                return 0;
            }
            return num == 1 ? 1 : num * FirstFactorial_Final(num - 1);
        }
        private static int result = 0;
        public static int FirstFactorial(int num)
        {

            if (num <= 0)
            {
                return 0;
            }
            if (num == 1)
            {
                return 1;
            }
            result = num;
            FractionSteps(ref num);
            return result;

        }

        public static void FractionSteps(ref int num)
        {
            result *= --num;
            if (num <= 1)
            {
                return;
            }
            else
            {
                FractionSteps(ref num);
            }
        }

        // keep this function call here
        public static void Implement()
        {
            //40320
            Console.WriteLine(FirstFactorial_Final(8));

        }
    }
}
