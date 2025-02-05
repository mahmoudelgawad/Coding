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

        public static Dictionary<string, string> CreateVehicleDetails() 
        {
            Dictionary<string, string> vehicleDetails = new Dictionary<string, string> 
            {
             {"DVLA_Make","VOLKSWAGEN"},
             {"DVLA_Model","CADDY MAXI C20 STARTLINE"},
             {"Transmission","MANUAL"},
             {"Eire_ChassisNumber","WV1ZZZ2KZGX126901"},
             {"Eire_Vrm",null},
             {"VRM_Curr","" },
             {"VRM_MVRIS", "MW16FNE"}
            };

            return vehicleDetails;
        }
    }
}
