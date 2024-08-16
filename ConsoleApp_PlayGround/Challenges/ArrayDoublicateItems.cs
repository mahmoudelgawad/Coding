using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Challenges
{
    internal class ArrayDoublicateItems
    {

        public static void Implement() 
        {
            //var ar = new int[9] {5,4,66,4,7,8,6,1,4};
            int[] arr = { 5, 4, 66, 4, 7, 8, 6, 1, 4, 66, 6 };
            List<int> doubleValues = new List<int>();
            for (int i = 0; i < arr.Length; i++) 
            {
                for (int ii = 0; ii < arr.Length; ++ii) 
                {
                    if ((arr[i] == arr[ii]) && (i != ii)) 
                    {
                        if (doubleValues.Contains(arr[i])) 
                        {
                            break;
                        }
                        doubleValues.Add(arr[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(',', doubleValues.ToArray()));
        }
    }
}
