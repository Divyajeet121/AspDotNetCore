using Aspdotnetcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspdotnetcore.EmployeeData
{
     public interface IEmployee
    {

      

        List<Employee> GetEmployees();

        Employee GetEmployee(Guid id);
        Employee AddEmployee(Employee obj);
        Employee EditEmployee(Employee obj);
        void DeleteEmployee(Employee obj);
    }
}
