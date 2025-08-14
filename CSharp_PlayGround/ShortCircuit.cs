using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    internal class ShortCircuit
    {
        //short circuits is && - ||

        // c1-false && c2-true // c1 will checked but c2 not, and condition not success
        // c1-false & c2-true // c1 will checked and c2 checked, and condition not success


        // c1-true || c2-true // c1 will checked but c2 not, and condition will success
        // c1-true | c2-true // c1 will checked and c2 checked, and condition will success
        public bool condition1() 
        {
            Console.WriteLine("condition1");
            return true;
        }

        public bool condition2() 
        {
            Console.WriteLine("condition2");
            return true;
        }

    }

    public class ShortCircuitImplementation
    {
        public static void Implement() 
        {
            ShortCircuit shortCircuit = new ShortCircuit();

            if (shortCircuit.condition1() | shortCircuit.condition2()) 
            {
                Console.WriteLine("evaluate for & is done");
            }
        }
    }
}
