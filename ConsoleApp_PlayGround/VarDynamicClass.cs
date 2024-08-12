using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    internal class VarDynamicClass
    {

        public static void Implement() 
        {
            dynamic x = "c#";
            var y = 10;
            Console.WriteLine(x.Length);
            Console.WriteLine(y);
            x = 1 + 5; // dynamic accept change the data type in runtime
            //y = "sdsdsd"; // error: it should integer not string
            Console.WriteLine(++x);
            Console.WriteLine(y + "  GOGO");
        }
    }
}
