using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    internal class OuterClass
    {
        public class NestedClassA
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
       static internal class NestedClassB
        {
            public static string Address { get; set; }
            public static int BuildingNo { get; set; }
        }
    }

    // yes it can allowed inherit from nested class, if it is accessible
    internal class OtherOuterClass : OuterClass.NestedClassA 
    {
        public OtherOuterClass() 
        {
            Name = "OtherOuterClass";
            Age = 1;
        }
    }

    // cannot inherit / derived from static class
    //internal class OtherOuterClassB : OuterClass.NestedClassB{}
    public class NestedClassImplementation 
    {
        public static void Implement() 
        {
            OtherOuterClass otherOuterClass = new OtherOuterClass();
            Console.WriteLine("[NestedClassImplementation]:\r\n" +
                             $"Name: {otherOuterClass.Name}\r\n" +
                             $"Age:{otherOuterClass.Age}");
        }
    }

}
