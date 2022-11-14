using Aspdotnetcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspdotnetcore.EmployeeData
{
    public interface IStudent
    {
        List<Student> GetStudents();
        Student addStudent(Student obj);
    }
}
