using ConsoleApp_PlayGround.AttributeInfo;
using ConsoleApp_PlayGround.Challenges.CoderByte;
using ConsoleApp_PlayGround.Compare;
using ConsoleApp_PlayGround.Delegate;
using ConsoleApp_PlayGround.ParallelThread;

using ConsoleApp_PlayGround.Strings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using ConsoleApp_PlayGround.DTO;
using ConsoleApp_PlayGround.LINQ;
using ConsoleApp_PlayGround.Challenges.LeetCode;
using ConsoleApp_PlayGround.IO;

namespace ConsoleApp_PlayGround
{
    class Program
    {
        static async Task Main(string[] args)
        {

            // ReadonlyClassImplementation.Implement();

            ConsoleApp_PlayGround.Challenges.CoderByte.CodeLandUsernameVailidation
                 .Main();

            //just comment
            Console.WriteLine("\r\nConsoleApp_PlayGround SUCCESS!\r\n");


        }
    }
}
