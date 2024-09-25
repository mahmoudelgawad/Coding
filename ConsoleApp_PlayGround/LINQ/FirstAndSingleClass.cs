using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.LINQ
{
    internal class FirstAndSingleClass
    {
        string[] MyFruits = { "Apple", "Date", "Mango", "WaterMelon" , "akoka"};
        string[] MyFruitsEmpty = { };

        public void GetFirstFruit() 
        {
            string fruit;
            fruit = MyFruits.First( f => f.ToLower().StartsWith("a"));
            fruit = MyFruits.FirstOrDefault(f => f.ToLower().StartsWith("a"));
        }

        public void GetSingleFruit()
        {
            string fruit;
            fruit = MyFruits.Single(f => f.ToLower().StartsWith("a"));
            fruit = MyFruits.SingleOrDefault(f => f.ToLower().StartsWith("a"));
        }

        public void GetLastFruit()
        {
            string fruit;
            fruit = MyFruits.Last(f => f.ToLower().StartsWith("a"));
            fruit = MyFruits.LastOrDefault(f => f.ToLower().StartsWith("a"));
        }


    }
}
