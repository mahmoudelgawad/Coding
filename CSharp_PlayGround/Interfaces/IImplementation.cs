using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Interfaces
{
    internal interface IImplementation
    {
        // it just available in C# 11 version
        //abstract static void Implement();

        //int varInt; //ERROR: no instance fileds in interface

        //string Name { get; set; }

        //public string Name { get; set; } //public access modifier only allowed
        void Implement();
    }
}
