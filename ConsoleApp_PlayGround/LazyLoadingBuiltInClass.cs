using System;
using ConsoleApp_PlayGround.DTO;
using System.Collections.Generic;


namespace ConsoleApp_PlayGround
{
    internal class LazyLoadingBuiltInClass
    {
        //can handle with safe thread
        private Lazy<List<Employee>> _employees = null;
        LazyLoadingBuiltInClass()
        {
            _employees = new Lazy<List<Employee>>(() => LoadEmployees());
        }
        public List<Employee> Employees
        {
            get
            {
                return _employees.Value;
            }
        }

        public List<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Employee() { FirstName = "mustafa", LastName = "Mohamed" }
            };
        }
    }
}
