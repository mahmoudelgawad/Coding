using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    //reference:
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/readonly
    public class ReadonlyClass
    {
        //different in initalization
        //initalize in constructor or definition only
        private readonly int _readonlyVar; 
        public readonly int readonlyVar2;

        // must initalize
        // implicitly static - can call const vairable as static field
        private const int _constVar = 15; 
        public const int constVar2 = 20; 
        public ReadonlyClass(int var1) 
        {
           // _readonlyVar = var1; // OK initialize in the constructor
          //  _constVar = var1; // error
        }

        public int Method1() 
        {
            //_readonlyVar = 12; // ERROR, initalize in constructor or definition only
            //_readonlyVar = +1; //error, must assing in constructor or when initialize only
            //_constVar = +2; // error
            return _readonlyVar;
        }
    }

    public class ReadonlyClassImplementation 
    {
        public static void Implement() 
        {
            ReadonlyClass readonlyClass = new ReadonlyClass(2);
            Console.WriteLine(readonlyClass.Method1());
        }
    }

}
