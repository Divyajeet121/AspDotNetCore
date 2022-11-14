using Aspdotnetcore.EmployeeData;
using Aspdotnetcore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspdotnetcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _student;
        public StudentController(IStudent student)
        {
            _student = student;
        }

        [HttpGet]
        [Route("getstudents")]
        public IActionResult getEmployee()
        {
            return Ok(_student.GetStudents());
        }



        [HttpPost]
        [Route("add")]
        public IActionResult addEmployee(Student obj)
        {
            _student.addStudent(obj);
            return Ok (obj);
        }
    }
}
