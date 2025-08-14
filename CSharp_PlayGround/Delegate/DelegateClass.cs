using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Delegate
{       
    //delegate definition can be nested inside class or namespace
    //it is call back methods, but not encapsulated
    public delegate void PrintMessageDelgate(string str);

    internal class DelegateClass
    {

        //intialise delegate instance to use it
        //use event with delegate instance, for publisher/subscriper model and encapsulated

        //event use delegate internally, it encapsulate the delegeates and make them safe, 
        //prevent from assign '=' direct to 'null' value specially outside the class at compile time
        //outside definition class use += or -=
        public   PrintMessageDelgate printMsgDelgObj = null;
        public event PrintMessageDelgate printMsgDelgEventObj = null;


        public void PrintCustomMessage(string str) 
        {
            Console.WriteLine(str);
        }

        public void PrintHelloMessage(string str)
        {
            Console.WriteLine($"Hello: {str}");
        }

        public void Implement(string msg = null) 
        {
            printMsgDelgObj("I am normal delgate");
            printMsgDelgEventObj(msg);
        }
    }

    public class DelegateClassImplemntation 
    {
        public static void Implement() 
        {
            DelegateClass delegateClassObj = new DelegateClass();
            delegateClassObj.printMsgDelgObj = null; //no error
           // delegateClassObj.printMsgDelgEventObj = null; //error need '+=' or '-='

            delegateClassObj.printMsgDelgObj = delegateClassObj.PrintCustomMessage;
            delegateClassObj.printMsgDelgEventObj += delegateClassObj.PrintHelloMessage;
            delegateClassObj.Implement("called event from outside own class");

        }
    }
}
