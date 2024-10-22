using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Compare
{
    public interface IPerson : IComparable<IPerson>
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
    public class Person :IPerson
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
        // return -1 current instance item
        // return 0 current instance same position as other
        // return 1 for other
        // this.Age.CompareTo(other.Age);
        public int CompareTo(IPerson other)
        {
            //you can use single Line 
            // return this.Name.CompareTo(other.Name);
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
        public static void Implement(bool showError = false)
        {
            var personsNotComparable = new List<PersonNotComparable>
            {
                new PersonNotComparable{ Name= "mahmoud",Age=41 },
                new PersonNotComparable{ Name= "rohagi",Age=40 },
                new PersonNotComparable{ Name= "jolaji",Age=25 },
                new PersonNotComparable{ Name= "sonwarson",Age=31 },
                new PersonNotComparable{ Name= "oakka",Age=10 }
            };

            //*Note
            //DisplayPersons(personsNotComparable);
            if (showError) 
            {
             personsNotComparable.Sort(); // ERROR: sort will confused, Invalid operation exception
            }
            



            var persons = new List<IPerson>
            {
                new Person{ Name= "Mahmoud",Age=41 },
                new Person{ Name= "Oakka",Age=10 },
                new Person{ Name= "Rohagi",Age=40 },
                new Person{ Name= "Jolaji",Age=25 },
                new Person{ Name= "Sonwarson",Age=31 },
 
            };



            DisplayPersons(persons);
            persons.Sort();
            DisplayPersons(persons);




        }

        public static void DisplayPersons(List<IPerson> persons) 
        {
            foreach (var p in persons) 
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }
            Console.WriteLine("-----------------------------------");
        }
    }
}
