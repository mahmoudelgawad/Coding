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
using ConsoleApp_PlayGround.IO;
using LettCode = ConsoleApp_PlayGround.Challenges.LeetCode;
using HackerRank = ConsoleApp_PlayGround.Challenges.HackerRank;
using ConsoleApp_PlayGround.Challenges.Other;
using ConsoleApp_PlayGround.DataStructure;
using ConsoleApp_PlayGround.Nullable;
using ConsoleApp_PlayGround.OOP.CovarianceAndContravariance;
using ConsoleApp_PlayGround.Challenges.LeetCode;


namespace ConsoleApp_PlayGround
{
    class Program
    {
        static async Task Main(string[] args)
        {
            LongestSubstringClass.Implement();       

            //TODO: upgrade to .net 10 & VS 2026
            //https://dotnet.microsoft.com/en-us/download/visual-studio-sdks

            //just comment
            Console.WriteLine("\r\nConsoleApp_PlayGround SUCCESS!\r\n");
        }
    }
}
