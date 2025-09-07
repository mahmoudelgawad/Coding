using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class PassingByReferenceClass
    {
        int value = 0;
        public void UsingIntRef(ref int value)
        {
            value += 10;
            Console.WriteLine("UsingIntRef, will not change it.");
        }

        public void UsingObjRef(ref User user) 
        {
            user.Name = "Osman";
            user.Age = 15;
        }
        public void UsingIntOut(out int value)
        {
            value = 10;
        }

        public void UsingObjOut(out User user)
        {
            //#must initialize out parameter
            user = new User();

            user.Name = "Osman";
            user.Age = 15;
        }

        public void UsingIntIn(in int value)
        {
            //value = 10; // error: it's read only
            Console.WriteLine($"UsingIntIn, value = {value}"); // value is readonly
        }

        public void UsingObjIn(in User user)
        {
            //user = new User(); // Error because its readonly
            // but you can change the values of properties for class instance
            user.Name = "Osman";
            user.Age = 15;
        }

        //other usage for 'ref' keyword
        //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref

        //using ref in method signature, value return by reference 'ref return'
        public ref int ReturnReferenceValue_RefMax(ref int left, ref int right)
        {
            if (left > right)
            {
                return ref left;
            }
            else
            { 
                return ref right;
            }              
        }

        //using ref in local variable declaration, reference variable
        public void DeclareLocalReferenceVariable(int variable) 
        {
            ref int localVariable = ref variable;
        }

        //conditional reference expression,or reference assignment
        public ref int ReturnReferenceValue_RefMax_ByCondition(ref int left, ref int right)
        {
            ref int maxValue =ref left > right ? ref left : ref right;
            return ref maxValue;
        }



    }

    public class PassingByReferenceImplementation
    {
        public static void Implement() 
        {
            PassingByReferenceClass passingByReferenceClass = new PassingByReferenceClass();
            User userObj = new User { Name = "mahmoud", Age = 16 };
            User userObjNull;

            //#Error use unassigned variable
            //passingByReferenceClass.UsingObjRef(ref userObjNull);
            passingByReferenceClass.UsingObjOut(out userObjNull);
        } 
    }
}
