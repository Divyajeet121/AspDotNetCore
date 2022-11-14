using Aspdotnetcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspdotnetcore.EmployeeData
{
    public class TeacherRepo : ITeacher
    {

        private readonly EmployeeContext _employeeContext;

        public TeacherRepo(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public Teacher addTeacher(Teacher obj)
        {
            _employeeContext.teacher.Add(obj);
            _employeeContext.SaveChanges();
            return obj;
        }

        public bool deleteteacher(Teacher obj)
        {
            _employeeContext.teacher.Remove(obj);
            int isDelete = _employeeContext.SaveChanges();
            if (isDelete > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<dynamic> GetName()
        {
            var Data = (from emp in _employeeContext.teacher
                        join std in _employeeContext.students on emp.id equals std.id
                        
                        select new
                        {
                            emp.id,
                            emp.teacher_name,
                            emp.teacher_salary,
                            std.name
                        }).ToList<dynamic>();
            return Data;
        }

        public List<Teacher> GetTeachers()
        {
            return _employeeContext.teacher.ToList();
        }
    }
}
