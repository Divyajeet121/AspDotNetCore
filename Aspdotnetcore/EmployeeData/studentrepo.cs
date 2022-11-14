using Aspdotnetcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspdotnetcore.EmployeeData
{
    public class studentrepo : IStudent
    {
        private EmployeeContext _employeeContext;
        public studentrepo(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public Student addStudent(Student obj)
        { 
            _employeeContext.students.Add(obj);
            _employeeContext.SaveChanges();
            return obj;
        }

        public List<Student> GetStudents()
        {
            return _employeeContext.students.ToList();
        }
    }
}
