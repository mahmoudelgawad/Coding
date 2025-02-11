using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    internal class ExtensionMethod
    {
        public void IntArrayOrderBy() 
        {
            int[] ints = {12,50,60,9,40,7,41 };
            ints.OrderBy(i => i);
        }
    }
}
