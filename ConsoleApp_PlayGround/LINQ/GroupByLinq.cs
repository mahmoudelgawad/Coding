using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_PlayGround.DTO;

namespace ConsoleApp_PlayGround.LINQ
{
    internal class GroupByLinq
    {
        private List<Employee> _employeeList = GenerateData.CreateEmployeeListData();

        public void GroupByEmployeePosition() 
        {
            var groupByPositionResult = _employeeList.GroupBy(e => e.Position).ToList();
        }

        public void GroupByEmployeePositionSalary()
        {
            var groupByPositionSalaryResult = _employeeList.GroupBy(
                e => e.Position, // key 
                (key,group) => new {posistion = key,total = group.Sum(e => e.Salary)}).ToList(); // aggregation with salary
        }

    }

    public class GroupByLinqImplemntation 
    {
        public static void Implement() 
        {
            GroupByLinq groupByLinq = new GroupByLinq();
            //groupByLinq.GroupByEmployeePosition();
            groupByLinq.GroupByEmployeePositionSalary();
        }
    }
}
