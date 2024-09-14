using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    internal class YieldReturnClass
    {
        //yield return help for
        //1- return custome iteration collection instead use tempdata
        //2- statful iteration

        private List<string> strList = new List<string> { "mahmoud", "ahmed", "mohamed", "yazeed" };
        private List<int> numList = new List<int> {1,2,3,4,5};
        public IEnumerable<string> getStringValues() 
        {
            foreach (var str in strList) 
            {
                yield return str+ " -Edited";               
            }
        }

        // just return filtered new collection instead use tempdata
        public IEnumerable<string> FilterStringsValues() 
        {
            foreach (var str in strList) 
            {
                if (str.ToLower().StartsWith("m")) 
                {
                   yield return str; // just reurn new collection instead use tempdata
                }
            }
        }

        //implement statful iteration with yield return
        public IEnumerable<int> getTotal() 
        {
            int total = 0;
            foreach (var i in numList) 
            {
                total += i;
                // just it's send data to the caller and return for the next
                // not wait until to fill and return new collecion
                Console.WriteLine($"ready for next value: {i}");
                yield return total;
            }
        }
    }

   public class YiledReturnImplementation 
    {
        public static void Implement() 
        {            
            var yieldRetrunObj = new YieldReturnClass();
            var values = yieldRetrunObj.getStringValues();
            Console.WriteLine(string.Join(",",values.ToArray()));

            foreach (var i in yieldRetrunObj.getTotal()) 
            {
                Console.WriteLine(i);
            }
        }
     
    }
}
