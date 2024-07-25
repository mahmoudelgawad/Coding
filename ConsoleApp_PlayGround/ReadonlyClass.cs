using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/readonly
    public class ReadonlyClass
    {
        private readonly int _readonlyVar; //different in initalization
        public readonly int readonlyVar2; //different in initalization

        private const int _constVar = 15;
        public const int constVar2 = 20; // implicitly can call const vairable as static field
        public ReadonlyClass(int var1) 
        {
            //_readonlyVar = var1;
          //  _constVar = var1; // error
        }

        public int Method1() 
        {
            //_readonlyVar = +1; //error
            //_constVar = +2; // error
            return _readonlyVar;
        }
    }
}
