using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Nullable
{
    public class NullableClass
    {

        //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
        // "??" Null-coalescing operator
        // "??=" Null-Coalescing assignment operator
        //both for avoid if else or ternary operator
        public static void ImplementNullCoalescingOperators() 
        {
            int? num1 = null;
            int? num2 = null;

            int? result = num1 ?? num2;
            Console.WriteLine($"result == null -> {result == null}"); //true

            string name = null;
            string displayName = name ?? "No Name";
            Console.WriteLine($"displayName = {displayName}"); // "No Name"

            int? n1 =null, n2=null, n3 = null;
            n3 = 15;
            result = n1 ?? n2 ?? n3;
            Console.WriteLine($"result = {result}"); // 15
        }

        public static void ImplementNullCoalescingAssignmentOperators()
        {
            string name = "defaultName";
            name ??= "Mahmoud";
            // "defaultName" because name non-null
            Console.WriteLine($"name = {name}");

            string address = null;
            address ??= "9 green street";
            Console.WriteLine($"address = {address}");
        }

        public static void Implement() 
        {
            ImplementNullCoalescingOperators();
            ImplementNullCoalescingAssignmentOperators();
        }
    }
}
