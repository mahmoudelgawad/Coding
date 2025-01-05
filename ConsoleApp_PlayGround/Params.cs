using ConsoleApp_PlayGround.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    internal class ParamsClass
    {
        //not supported yet, on in preview version
        //void RecieveParamsAsList(params List<Employee> employees)
        //{

        //}
       public void RecieveParamsAsArray(params List<Employee>[] employees) 
        {
            Console.WriteLine($"you passed array of length ={employees.Length}");
        }
    }

    public class ParamsClassImplementation 
    {
        public static void Implement() 
        {
            var paramsObj = new ParamsClass();
            paramsObj.RecieveParamsAsArray(new List<Employee> { new Employee {FirstName = "mahmoud", LastName="ahmed"} });
        }
    }
}
