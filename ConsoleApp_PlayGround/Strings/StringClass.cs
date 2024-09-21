using System;

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
            String strClass = new String(['s', 'd']);
            String.IsNullOrEmpty(strClass);
            string str = "";
            //str.IsNullOrEmpty("");//Error


            StringClass.IsValid(str);

            StringClass stringClassObj = new StringClass();
            //use type name instead to access static member with instance
            //stringClassObj.IsValid(str); //Error
        }
    }
}
