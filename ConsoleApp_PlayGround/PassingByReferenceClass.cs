using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class PassingByReferenceClass
    {
        int value = 0;
        public void UsingIntRef(ref int value)
        {
            value += 10;
            Console.WriteLine("UsingIntRef, will not change it.");
        }

        public void UsingObjRef(ref User user) 
        {
            user.Name = "Osman";
            user.Age = 15;
        }
        public void UsingIntOut(out int value)
        {
            value = 10;
        }

        public void UsingObjOut(out User user)
        {
            user = new User();
            user.Name = "Osman";
            user.Age = 15;
        }

        public void UsingIntIn(in int value)
        {
            //value = 10; // error: it's read only
            Console.WriteLine($"UsingIntIn, value = {value}"); // value is readonly
        }

        public void UsingObjIn(in User user)
        {
            //user = new User(); // Error because its readonly
            // but you can change the values of properties for class instance
            user.Name = "Osman";
            user.Age = 15;
        }
    }
}
