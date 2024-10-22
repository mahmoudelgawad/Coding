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

            /* HashSet<int> set = new HashSet<int>();
             set[0].
            */

            Dictionary<string, int> dict = new Dictionary<string,int>();
            var intValueDict = dict["key"]; // index as string same 'Key' type
            var intValueList = list[0]; // index as int for List like Array


            LinkedList<int> llist = new LinkedList<int>(list);
            var v = list[0]; // index in list
            //var lv = llist[0]; // ERROR: no index with linked list

            list.Sort(); // list has sort() default comparer, but linked list not

            list.Add(5);
            llist.AddAfter(llist.Find(5), 6); // effecient in adding items in the middle or first , last
        }
    }
}
