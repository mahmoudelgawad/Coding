using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    internal class ExceptionHandling
    {
        public void MainFun() 
        {
            Fun1();
        }
        public void Fun1()
        {
            try
            {
                Fun2();
            }
            catch(Exception)
            {
                throw;
            }
            finally 
            {
                Console.WriteLine("finally of Fun1 process");
            }
        }

        public void Fun2() 
        {            
           throw new Exception("Exception from Fun2");         
        }
    }

   public class ExceptionHandlingImplementation
    {
        public static void Implement() 
        {            
            var yieldRetrunObj = new YieldReturnClass();
            var values = yieldRetrunObj.getStringValues();
            Console.WriteLine(string.Join(",",values.ToArray()));

            foreach (var i in yieldRetrunObj.getTotal()) 
            {
                Console.WriteLine(i);
            }
        }
     
    }
}
