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
    public class TeacherController : ControllerBase
    {
        private readonly ITeacher _teacher;
        public TeacherController(ITeacher teacher)
        {
            _teacher = teacher;
        }


        [HttpGet]
        [Route("GetTeachers")]
        public IActionResult GetTeachers()
        {
            return Ok(_teacher.GetTeachers());
        }


        [HttpPost]
        [Route("add")]
        public IActionResult addEmployee(Teacher obj)
        {
            _teacher.addTeacher(obj);
            return Ok(obj);
        }


        [Route("Getname")]
        [HttpGet]
        public IEnumerable<dynamic> GetName()
        {
            return _teacher.GetName();
        }

        [Route("deleteTeacher")]
        [HttpPost]
        public IActionResult deleteteacher(Teacher obj)
        {
            bool isDelete = _teacher.deleteteacher(obj);
            if (isDelete)
            {
                return Ok(new { status = "success", message = "deleted successfully", value = "" });
            }
            else
            {
                return BadRequest(new { status = "failure", message = "Unable to delete data", value = "" });
            }
        }
    }
}
