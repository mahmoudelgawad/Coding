using System;
using System.Globalization;
using System.Linq;

namespace ConsoleApp_PlayGround.Strings
{

    public sealed partial class StringClass
    {
        //nullable annotation .NET 8
#nullable enable
        public static bool IsValid(string? value)
        {
            return value != null;
        }
#nullable disable

        public void ReverseStringWays() 
        {
            string str = "mahmoud ahmed";

            //# 1) built in Join return reversed IEnumerable
            Console.WriteLine(string.Join("", str.Reverse()));

            //# 2) for loop
            for (int i = str.Length - 1; i >= 0; i--) Console.Write(str[i]);
            Console.WriteLine();

            //# 3) Array.Reverse
            var arrstr = str.ToArray();
            Array.Reverse(arrstr);
            Console.WriteLine(string.Join("", arrstr));
        }

    }

    public class StringClassImplemenatation 
    {
        public static void Implement() 
        {
            // alias name System.String like object -> System.Object
            //System.String class , is  public sealed partial class
            String strClass = new String(['s', 'd']);
            //contain helper static functions
            bool isNull =  String.IsNullOrEmpty(strClass);
        

            //builtin variable string
            string str = "";
            //str.IsNullOrEmpty("");//Error
            var upperCase = str.ToUpper();

            //our custom 
            StringClass.IsValid(str);
            StringClass stringClassObj = new StringClass();
            //use type name instead to access static member with instance
            //stringClassObj.IsValid(str); //Error
        }
    }
}
