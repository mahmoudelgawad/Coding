using ConsoleApp_PlayGround.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    struct PointValue 
    {
        // static variable even if it is value type , stored in the heap
        public static int X;
        public int Y;
       public PointValue(int x,int y) 
       {
            X = x;
            Y = y;
       }
    }

    struct CircleValue 
   {
        public int I;
        private int Do;
        public int GetDo(int d) 
        {
            Do = d;
            return I * Do;
        }
   }
    internal class StructImplementation : Iimplementation
    {
        public static void Implement() 
        {
            CircleValue cicle = new CircleValue { I = 13 };
            cicle.GetDo(3);
        }
        void Iimplementation.Implement() 
        {
            Implement();
        }
    }
}
