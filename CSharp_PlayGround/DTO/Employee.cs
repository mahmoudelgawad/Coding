using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.DTO
{
    [Serializable]
    public  class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public readonly string Name { get;  } //not valid with readonly
        public string Position { get; set; } = "employee";
        public float Salary { get; set; } = 0.0f;
    }
}
