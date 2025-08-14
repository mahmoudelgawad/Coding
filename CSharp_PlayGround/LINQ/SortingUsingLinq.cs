using ConsoleApp_PlayGround.Compare;
using ConsoleApp_PlayGround.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.LINQ
{
    internal class SortingUsingLinq
    {
        List<Employee> employess = new List<Employee>
            {
                new Employee{ FirstName= "Mahmoud",LastName="Ahmed"},
                new Employee{ FirstName= "Oakka",LastName="bolak"},
                new Employee{ FirstName= "Rohagi",LastName="janti" },
                new Employee{ FirstName= "Jolaji",LastName="bogo" },
                new Employee{ FirstName= "Sonwarson",LastName="goodsfi" },
            };

        //OrderBy
        //OrderByDescending
        //Reverse
        //ThenBy
        //ThenByDescending

        public void IntArraySortVsOrderBy()
        {
            int[] ints = { 12, 50, 60, 9, 40, 7, 41 };
            //ints.OrderBy(i => i);
            ints.ToList().Sort();
            //#nothing
            Console.WriteLine(string.Join(',',ints));

            Array.Sort(ints);
            Console.WriteLine(string.Join(',',ints));
        }

        void UseOrderBy() 
        {
            employess.OrderBy(e => e.FirstName);
        }
    }

    public static class SortingUsingLingImplementation 
    {
        public static void Implement()
        {
            SortingUsingLinq sortingUsingLinq = new SortingUsingLinq();
            sortingUsingLinq.IntArraySortVsOrderBy();
        }
    }

    
}
