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
        public readonly List<int> myNumbers = new List<int>{ 1,2,3,4,5 };

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

        public void EditMyNumbersReadonlyList() 
        {
            //it's not readonly list , you can edit it
            myNumbers.Add(20);
        }
    }

    class ConstReadOnlyTestClass 
    {
      public string FirstName { get; set; }
      public string LastName { get; set; }
    }

    //Immutable Properties with {get; init;}
    record class RecordTestClass(string FirstName = "Ezzeldin",string LastName="Ahmed");

    public class ReadonlyClassImplementation
    {
        // const ConstReadOnlyTestClass constObj = new ConstReadOnlyTestClass();//ERROR

        static readonly ConstReadOnlyTestClass readonlyObj = new ConstReadOnlyTestClass
            {FirstName = "Mahmoud", LastName="Ahmed" };

        static RecordTestClass recordObj = new RecordTestClass
        { FirstName = "EzzEldin", LastName = "Ahmed" };

        public static void Implement() 
        {
            ReadonlyClass readonlyClass = new ReadonlyClass(2);
            Console.WriteLine($"Method1: {readonlyClass.Method1()}");
            readonlyClass.EditMyNumbersReadonlyList();
            Console.WriteLine($"MyNumbers List count:{readonlyClass.myNumbers.Count()}");


            readonlyObj.FirstName = "soso";
            readonlyObj.LastName = "Boso";
            Console.WriteLine($"constObj as readonly :\r\n FirstName={readonlyObj.FirstName}, LastName={readonlyObj.LastName}");
            
            /* Error
            recordObj.FirstName = "alan";
            recordObj.LastName = "walan";
            Console.WriteLine($"recordObj :\r\n FirstName={recordObj.FirstName}, LastName={recordObj.LastName}");
            */
        }
    }

}
