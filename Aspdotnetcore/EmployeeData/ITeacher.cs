using Aspdotnetcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspdotnetcore.EmployeeData
{
   public interface ITeacher
    {
        List<Teacher> GetTeachers();
        Teacher addTeacher(Teacher obj);
        List<dynamic> GetName();

        bool deleteteacher(Teacher obj);


    }
}
