using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp_PlayGround.LINQ
{
    internal class SelectByLINQ
    {
        List<List<int>> nestedNumbers= new List<List<int>>
            {
                new List<int>{1,2,3},
                new List<int>{4,5 }    
            };

        public void SelectMethod()
        {
            var iEnumerableOfIntList = nestedNumbers.Select(l => l);
        }
        public void SelectManyMethod() 
        {
            //1,2,3,4,5
            var flatIEnumerableOfInt = nestedNumbers.SelectMany(l => l);
        }
    }
}
