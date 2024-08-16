using ConsoleApp_PlayGround.Challenges.CoderByte;
using ConsoleApp_PlayGround.compare;
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

            //VarDynamicClass.Implement();
            //ReadonlyClassImplementation.Implement();
            //AbstractClassImplementation.Implement();

            //ComparableBaseClassImplementation.Implement();
            //ComparableImplementation.Implement(true);

            ComparerImplementation.Implement();


            Console.WriteLine("ConsoleApp_PlayGround SUCCESS!");


        }
    }
}
