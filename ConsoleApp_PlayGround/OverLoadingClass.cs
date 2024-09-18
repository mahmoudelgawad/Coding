using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    internal class OverLoadingClass
    {

        public int ReturnValue(int v)
        {
            return 10;
        }

        // not accept overloading with only different in return type
        public string ReturnValue(int v) 
        {
            return v.ToString();
        }
        public string ReturnValue(string v)
        {
            return v.ToString();
        }
        public string ReturnValue(float v)
        {
            return v.ToString();
        }
    }

    public class OverLoadingClassImplementation
    {
        public static void Implement() 
        {
            OverLoadingClass overLoadingObj = new OverLoadingClass();
            Console.WriteLine($"{overLoadingObj.ReturnValue(10)} \r\n" +
                $"{overLoadingObj.ReturnValue("55")} \r\n" +
                $"{overLoadingObj.ReturnValue(5.6f)}");
        }
    }
}
