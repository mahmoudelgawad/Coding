using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
     class BaseClass
    {
        public int a = 0;
        //public BaseClass(int value)
        public BaseClass() 
        {
            a = 20;
        }
    }
    class ChildClass : BaseClass
    {
        public int b = 0;
        //public ChildClass(int value):base(value+1)

        //base constructor run by default
        public ChildClass(int value)
        {
            b = value;
        }

        public int BaseClassAValue() 
        {
            return base.a;
        }

    }

    public static class InheritanceImplementation 
    {
        public static void Implement() 
        {
            BaseClass baseClassObj = new BaseClass();
          
            ChildClass childClassObj = new ChildClass(6);
            Console.WriteLine("[InheritanceImplementation]:\r\n" +
                             $"a: {childClassObj.BaseClassAValue()}\r\n" +
                             $"b: {childClassObj.b}\r\n"+
                             $"baseClass.a: {baseClassObj.a}");
            
        }
    }
}
