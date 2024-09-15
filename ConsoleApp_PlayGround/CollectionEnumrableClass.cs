using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    internal class CollectionEnumrableClass
    {
        public void UseWhere() 
        {
            var list = new List<int> { 1, 5, 6, 10, 9, 16, 20 };
            //the query itself not implemented untill call Tolist or query with "Linq"
            list.Where(n => n > 10).ToList();
        }
    }
}
