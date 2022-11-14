

using Aspdotnetcore.Models;
using System;
using System.Collections.Generic;

namespace Aspdotnetcore.EmployeeData
{
    public class MockEmployeeData : IEmployee
    {


        private List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Divyajeet"
            },
             new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Divyajeet"
            }
        };

        public Employee AddEmployee(Employee obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(Employee obj)
        {
            throw new NotImplementedException();
        }

        public Employee EditEmployee(Employee obj)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
