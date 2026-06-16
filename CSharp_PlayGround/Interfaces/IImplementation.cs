using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Interfaces
{
    internal interface IImplementation
    {
        //################ FILEDS ##################
        //# ERROR: no instance fileds in interface
        //int varInt; 
        
        //################ PROPERTIERS ##################
        string Name { get; set; }
        //# Yes public access modifier only allowed (default is public)
        public string Color { get; set; } 

        

        //################ FUNCTIONS ##################
        void ImplementVoidFun();
        //#it just available in C# 11 version, [abstract / partial] + static
        abstract static void ImplementAbstractStaticVoidFun();
    }
}
