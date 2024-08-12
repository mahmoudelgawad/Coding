using ConsoleApp_PlayGround.Challenges.CoderByte;
using ConsoleApp_PlayGround.Delegate;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //Customer customer = new Customer();
            //customer.FirstName = "mahmoud";
            //customer.LastName = "ahmed";

            //Console.WriteLine(customer.GetName());

            VarDynamicClass.Implement();
            ReadonlyClassImplementation.Implement();

            //ArrayList lst = new ArrayList();
            //lst.Add("sdsd");
            //lst.Add(new Customer());

            //Console.WriteLine(ReadonlyClass.constVar2);

            //KeyAgeFinder objKeyAge = new KeyAgeFinder();
            //await objKeyAge.FindKeyAge();

            Console.WriteLine("ConsoleApp_PlayGround SUCCESS!");


        }
    }
}
