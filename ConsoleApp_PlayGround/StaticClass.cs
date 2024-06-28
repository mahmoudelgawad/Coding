using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
   static class StaticClass
    {
       readonly static string name = "mahmoud";

        //static class constructor not allow access modifier as "public constructor"
        static StaticClass()
        {
            // "this" keyword not valid for static method or static member
            //var obj = this.
        }

        public static string GetName() 
        {
            return "Static Class";
        }

        // extension method must be static
        public static string EnxtesnionOnString(this string argu) 
        {
            // "this" keyword not valid for static method or static member
            //var obj = this.
            return argu;
        }


    }
}
