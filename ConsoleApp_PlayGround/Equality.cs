using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    internal class Equality
    {
        //Object.Equals()
        //public virtual bool Equals(object? obj), in Object Class

        //valuetype
        //intnum.Equals()
        //public bool Equals(int obj), in structer System.Int32 Struct
        public void EqualSameReferenceAddress() 
        {
            object o = "Mahmoud Ahmed";
            object o2 = o;

            var equalOperator =  o == o2;
            var Equals = o.Equals(o2);
            Console.WriteLine($"OBJECT:\r\nequalOperator = {equalOperator}\r\nEquals= {Equals}");

            //value Type
            int num1 = 5;int num2 = num1;
            equalOperator = num1 == num2;
            Equals = num1.Equals(num2);
            Console.WriteLine($"INT:\r\nequalOperator = {equalOperator}\r\nEquals= {Equals}");
        }

        public void EqualDifferentReferenceAddress()
        {
            object o = "Mahmoud Ahmed";
            object o2 = new String("Mahmoud Ahmed");

            var equalOperator = o == o2;
            var Equals = o.Equals(o2);
            Console.WriteLine($"OBJECT:\r\nequalOperator = {equalOperator}\r\nEquals= {Equals}");

            //value Type
            int num1 = 5;
            int num2 = 5;
            equalOperator = num1 == num2;
            Equals = num1.Equals(num2);
            Console.WriteLine($"INT:\r\nequalOperator = {equalOperator}\r\nEquals= {Equals}");
        }


        //short circuits
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

    public class EqualityImplementation 
    {
        public static void Implement() 
        {
            Equality eq = new Equality();
            eq.EqualSameReferenceAddress();
            Console.WriteLine("\r\n\r\n");
            eq.EqualDifferentReferenceAddress();

            if (eq.condition1() | eq.condition2()) 
            {
                Console.WriteLine("evaluate for & is done");
            }


        }
    }
}
