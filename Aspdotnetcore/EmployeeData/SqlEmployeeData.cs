using Aspdotnetcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspdotnetcore.EmployeeData
{
    public class SqlEmployeeData : IEmployee
    {
        private EmployeeContext _employeeContext;
        public SqlEmployeeData(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public Employee AddEmployee(Employee obj)
        {
            obj.Id =  Guid.NewGuid();
            _employeeContext.employees.Add(obj);
            _employeeContext.SaveChanges();
            return obj;
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
            return _employeeContext.employees.ToList();
        }
    }
}
