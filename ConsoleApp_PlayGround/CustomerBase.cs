using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    class CustomerBase
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string CreditCardNumber { get; set; }

        public CustomerBase() 
        {
        
        }

        public string GetName() 
        {
            return FirstName + " " + LastName;
        }


    }
}
