using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.compare
{
    public class UserBase : IComparable<UserBase>
    {
       public virtual String Name { get; set; }
       public virtual int Age { get; set; }
        public virtual int CompareTo(UserBase other) 
        {
            return 0;
        }
    }
    public class UserNotComparable :UserBase
    {
        private string _name;
        private int _age;

        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override int Age
        {
            get { return _age; }
            set { _age = value; }
        }        
    }
    public class User :UserBase
    {
        private string _name;
        private int _age;

        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        //private int CompareTo(User other) // ERROR: can not implement because its private
        public override int CompareTo(UserBase other)
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
    public class ComparableBaseClassImplementation
    {
        public static void Implement()
        {
            var usersNotComparable = new List<UserBase>
            {
                new UserNotComparable{ Name= "Mahmoud",Age=41 },
                new UserNotComparable{ Name= "Oakka",Age=10 },
                new UserNotComparable{ Name= "Rohagi",Age=40 },
                new UserNotComparable{ Name= "Jolaji",Age=25 },
                new UserNotComparable{ Name= "Sonwarson",Age=31 },
 
            };

            //*Note
            DisplayUsers(usersNotComparable);
            usersNotComparable.Sort(); // will not show error bcasue will implement UserBase CompareTo
            DisplayUsers(usersNotComparable);

            Console.WriteLine("\r\n\r\n");


            var users = new List<UserBase>
            {
                new User{ Name= "Mahmoud",Age=41 },
                new User{ Name= "Oakka",Age=10 },
                new User{ Name= "Rohagi",Age=40 },
                new User{ Name= "Jolaji",Age=25 },
                new User{ Name= "Sonwarson",Age=31 },
            };



            DisplayUsers(users);
            users.Sort();
            DisplayUsers(users);




        }

        public static void DisplayUsers(List<UserBase> users) 
        {
            foreach (var u in users) 
            {
                Console.WriteLine($"{u.Name} - {u.Age}");
            }
            Console.WriteLine("-----------------------------------");
        }
    }
}
