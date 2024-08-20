using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.AttributeInfo
{
    [HelpText(HelpText ="This is Customer Class")]
    internal class Customer
    {
        private string _CustomerCode;

        [HelpText(HelpText ="This is just property")]
        public string CustomerCode
        {
            get { return _CustomerCode; }
            set { _CustomerCode = value; }
        }

        [Obsolete]
        public void Method() 
        {
            Console.WriteLine("Customer.Method()");
        }

        //force not used
        [Obsolete("just not use this use MethodAlex instead",true)]
        public void MethodCairo()
        {
            Console.WriteLine("Customer.MethodCairo()");
        }

        [HelpText(HelpText ="Use this method")]
        public void MethodAlex()
        {
            Console.WriteLine($"Customer.MethodAlex()");
            
        }

    }

    public class AttributeClassImplementation 
    {
        public static void Implement() 
        {
            Customer CustomerObj = new Customer();
            CustomerObj.Method();
            //CustomerObj.MethodCairo(); //ERROR: obsolete true
            CustomerObj.MethodAlex();

        
        }
    
    }
}
