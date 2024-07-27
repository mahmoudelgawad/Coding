using System;
using System.Collections;

namespace ConsoleApp_PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {

            //Customer customer = new Customer();
            //customer.FirstName = "mahmoud";
            //customer.LastName = "ahmed";

            //Console.WriteLine(customer.GetName());

            //dynamic x = "c#";
            //var y = 10;
            //Console.WriteLine(x.Length);
            //Console.WriteLine(y);
            //x = 1 + 5;
            //y = "sdsdsd";
            //Console.WriteLine(++x);
            //Console.WriteLine(y+"  GOGO");

            ArrayList lst = new ArrayList();
            lst.Add("sdsd");
            lst.Add(new Customer());

            Console.WriteLine(ReadonlyClass.constVar2);


            Console.WriteLine("ConsoleApp_PlayGround SUCCESS!");

        }
    }
}
