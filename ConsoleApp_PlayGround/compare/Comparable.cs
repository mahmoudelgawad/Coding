using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.compare
{
    public interface IPersonBase : IComparable<IPersonBase>
    {
        String Name { get; set; }
        int Age { get; set; }
    }
    public class PersonNotComparable 
    {
        private string _name;
        private int _age;

        public  string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public  int Age
        {
            get { return _age; }
            set { _age = value; }
        }        
    }
    public class Person :IPersonBase
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
        public int CompareTo(IPersonBase other)
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
    public class ComparableImplementation
    {
        public static void Implement()
        {
            //var personsNotComparable = new List<IPersonBase>
            //{
            //    new PersonNotComparable{ Name= "Mahmoud",Age=41 },
            //    new PersonNotComparable{ Name= "Rohagi",Age=40 },
            //    new PersonNotComparable{ Name= "Jolaji",Age=25 },
            //    new PersonNotComparable{ Name= "Sonwarson",Age=31 },
            //    new PersonNotComparable{ Name= "Oakka",Age=10 }
            //};

            //DisplayPersons(personsNotComparable);
            //personsNotComparable.Sort(); // ERROR: sort will confused, Invalid operation exception



            var persons = new List<IPersonBase>
            {
                new Person{ Name= "Mahmoud",Age=41 },
                new Person{ Name= "Rohagi",Age=40 },
                new Person{ Name= "Jolaji",Age=25 },
                new Person{ Name= "Sonwarson",Age=31 },
                new Person{ Name= "Oakka",Age=10 }
            };



            DisplayPersons(persons);
            persons.Sort();
            DisplayPersons(persons);




        }

        public static void DisplayPersons(List<IPersonBase> persons) 
        {
            foreach (var p in persons) 
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }
            Console.WriteLine("-----------------------------------");
        }
    }
}
