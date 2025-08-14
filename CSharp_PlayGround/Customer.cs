using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    class Customer:CustomerBase
    {

        public Customer() 
        {
        
        }

       new public string GetName() 
        {
            return FirstName + " " + LastName +" :@CUSTOMER";
        }


    }
}
