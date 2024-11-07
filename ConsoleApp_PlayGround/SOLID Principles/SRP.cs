using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.SOLID_Principles
{
    //Single Responsibility
    internal class SRP
    {
    }
    public class Customer 
    {
        public string Name { get; set; }
        public string Address { get; set; }
        private int _amount;

        public int ClaculateDiscount(string location) 
        {

            if (location == "Palestine" && Address.Contains("gaza")) 
            {
                return 90;
            }

            return 2;
        }

    }
}
