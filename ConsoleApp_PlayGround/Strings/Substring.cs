using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Strings
{
    internal class SubstringClass
    {
        private static string name = "mahmoud, ahmed, abdelgawad";
        public static void Implement()
        {
            //get first name
            Console.WriteLine(name.Substring(0, name.IndexOf(',')));
            
        }
    }

}
