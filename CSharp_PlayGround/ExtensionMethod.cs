using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    /*
     Extension methods in C# are a feature that allow developers to add new methods to existing types without modifying their original source code or inheriting from them.
    They essentially enable you to "extend" a class or interface with new functionality,
     making it appear as though the new methods are part of the original type's instance. 
     Here's how they work: 
     Static Class and Method: Extension methods are defined as static methods within a static class.
     this Keyword: The key element is the this keyword placed before the first parameter of the static method.
     'this; mean the targeted type or instance value that call him self extend method
        to defferentiate when in case pass another parameter
     This parameter specifies the type that the extension method will "extend."
     */
    internal class ExtensionMethod
    {

    }

    //# extension mehtod must be defined in non-generic static class
    static class StringExtensionsMethods
    {
        //#must be public to apply on any string in the same namespace or project
        public static string CapitalizeFirstLetter(this string inputString) 
        {
            if (string.IsNullOrEmpty(inputString)) return inputString;
            //#Substring start from index to the end
            return char.ToUpper(inputString[0]) + inputString.Substring(1);
        }

        private static string CapitalizeFirstLetter_Private(this string inputString,string prefix)
        {
            if (string.IsNullOrEmpty(inputString)) return inputString;
            //#Substring start from index to the end
            return prefix + "-" + char.ToUpper(inputString[0]) + inputString.Substring(1);
        }

        public static string CallPrivateExtensionMehtod(string inputString) 
        {
           return inputString.CapitalizeFirstLetter_Private("Private");
        }
    }

    public static class ExtensionMehtodImplementation 
    {
        public static void Implement() 
        {
            string name = "software solutions";
            //#exist in 'StaticClass.cs' 
            name.ExtensionOnString();
            Console.WriteLine(name.CapitalizeFirstLetter());
            Console.WriteLine(StringExtensionsMethods.CallPrivateExtensionMehtod(name));
        }
    }
}
