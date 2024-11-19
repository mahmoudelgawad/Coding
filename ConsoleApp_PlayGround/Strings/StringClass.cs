using System;
using System.Globalization;

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
