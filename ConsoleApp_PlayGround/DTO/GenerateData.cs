using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.DTO
{
    internal class GenerateData
    {
        public static List<Employee> CreateEmployeeListData() 
        {
          List <Employee> employess = new List<Employee>
            {
                new Employee{ FirstName= "Mahmoud",LastName="Ahmed",Position = "manager",Salary=109.8f},
                new Employee{ FirstName= "Oakka",LastName="bolak",Salary=26.5f},
                new Employee{ FirstName= "Rohagi",LastName="janti",Salary=34.5f},
                new Employee{ FirstName= "Jolaji",LastName="bogo",Salary=44.3f },
                new Employee{ FirstName= "Sonwarson",LastName="goodsfi",Position = "manager",Salary=208.4f },
            };
            return employess;
        }   
    }
}
