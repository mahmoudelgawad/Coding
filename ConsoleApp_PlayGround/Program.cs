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

            dynamic x = "c#";
            Console.WriteLine(x.Length);
            x = 1 + 5;
            Console.WriteLine(++x);

            Console.WriteLine("ConsoleApp_PlayGround SUCCESS!");

        }
    }
}
