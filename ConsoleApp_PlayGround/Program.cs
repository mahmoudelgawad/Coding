using System;

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

            int? num1 = null;
            int? num2 = null;

            int? result = num1 ?? num2;
            Console.WriteLine(result == null);

            Console.WriteLine("ConsoleApp_PlayGround SUCCESS!");

        }
    }
}
