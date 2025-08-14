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
        public void ImplementNullCoalescingOperators() 
        {
            int? num1 = null;
            int? num2 = null;

            int? result = num1 ?? num2;
            Console.WriteLine(result == null);
        }
    }
}
