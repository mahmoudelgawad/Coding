using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Challenges.Other
{
    internal class CalculateFloatListClass
    {
        private static string CalculateFloatList(Dictionary<string, List<float>> lst) 
        {
            StringBuilder sb = new StringBuilder();
            float total = 0;
            foreach (var sheet in lst) 
            {
                float sum = sheet.Value.Sum();
                sb.AppendLine($"Sheet: {sheet.Key}, Total: {sum}");
                total += sum;
            }
            sb.AppendLine($"Total: {total}");
            return sb.ToString();
        }
        public static void Implement() 
        {
            var lstJune2025 = new Dictionary<string, List<float>>
           {
               { "card1",new List<float>
                   {
                   55,
                   29,
                   4219.69f,
                   25,
                   3000,
                   15,
                   129,
                   501.70f,
                   649.80f,
                   7.66f
                   }
               },
               { "card2",new List<float>
                   {
                   618,
                   554.4f,
                   649.8f,
                   811.55f,
                   1040.30f,
                   447.37f,
                   15,
                   1083.62f,
                   2784.65f,
                   662.98f,
                   206.74f,
                   380,
                   1802.22f,
                   1100,
                   450,
                   250,
                   2900
                   }
               }
           };
            Console.WriteLine(CalculateFloatList(lstJune2025));
        }
    }
}
