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
        //private void Implement() //: Error, you not implement the 'Iimplementation' interface
        public void Implement()
        {
            Console.WriteLine("just implement interface");
        }
    }
}
