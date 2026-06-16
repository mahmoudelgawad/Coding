using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Interfaces
{
    //to implement interface, members should with public access modifiers by default
    internal class ClassInterface:IImplementation
    {
        public string Name { get; set; }
        public string Color { get; set; }
        //private void Implement() //: Error, you not implement the 'Iimplementation' interface
        public void ImplementVoidFun()
        {
            Console.WriteLine("ClassInterface.Implement() -> Invoke");
        }

        public static void ImplementAbstractStaticVoidFun() 
        {
            Console.WriteLine("ClassInterface.ImplementAbstractStaticVoidFun() -> Invoke");
        }
    }
}
