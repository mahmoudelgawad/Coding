using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Compare
{
    interface IPersonComparer : IComparable<IPersonComparer>
    {
        String Name { get; set; }
        int Age { get; set; }
    }

     class PersonComparer : IPersonComparer
    {
        private string _name;
        private int _age;

        public  string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        //private int CompareTo(Person other) // ERROR: can not implement because its private
        public int CompareTo(IPersonComparer other)
        {
            if (other == null)
            {
                return 0;
            }
            else if (this.Age == other.Age)
            {
                return this.Name.CompareTo(other.Name);
            }
            else 
            {
                // 'this' sort by age ASCENDING
                // return this.Age.CompareTo(other.Age);

                // 'other' sort by age DESCENDING
                return other.Age.CompareTo(this.Age);
            }
        }
    }

    class SortByNameCriteria : IComparer<IPersonComparer> 
    {
        public int Compare(IPersonComparer a, IPersonComparer b) 
        {
            return string.Compare(a.Name, b.Name);
        }
    }

    class SortByAgeCriteria : IComparer<IPersonComparer>
    {
        public int Compare(IPersonComparer a, IPersonComparer b)
        {
            if (a.Age > b.Age) return 1;
            if (a.Age < b.Age) return -1;
            return 0;
        }
    }
    class SortByAgeDESCCriteria : IComparer<IPersonComparer>
    {
        public int Compare(IPersonComparer a, IPersonComparer b)
        {
            if (b.Age > a.Age) return 1;
            if (b.Age < a.Age) return -1;
            return 0;
        }
    }

    public class ComparerImplementation
    {
        public static void Implement()
        {

            var persons = new List<IPersonComparer>
            {
                new PersonComparer{ Name= "Mahmoud",Age=41 },
                new PersonComparer{ Name= "Oakka",Age=10 },
                new PersonComparer{ Name= "Rohagi",Age=40 },
                new PersonComparer{ Name= "Jolaji",Age=25 },
                new PersonComparer{ Name= "Sonwarson",Age=31 },
 
            };


            DisplayPersons(persons);
            persons.Sort(new SortByNameCriteria()); // just pass new instance from the Icomparer
            DisplayPersons(persons);

            Console.WriteLine("\r\n\r\n");
            persons.Sort(new SortByAgeCriteria());
            DisplayPersons(persons);

            Console.WriteLine("\r\n\r\n");
            persons.Sort(new SortByAgeDESCCriteria());
            DisplayPersons(persons);
        }

        private static void DisplayPersons(List<IPersonComparer> persons) 
        {
            foreach (var p in persons) 
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }
            Console.WriteLine("-----------------------------------");
        }
    }
}
