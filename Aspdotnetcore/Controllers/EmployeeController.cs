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
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employee;
        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }

        [HttpGet]
        [Route("okay")]
        public IActionResult getEmployee()
        {
            return Ok (_employee.GetEmployees());
        }


        [HttpPost]
        [Route("add")]
        public IActionResult addEmployee(Employee obj)
        {
            _employee.AddEmployee(obj);
            return Created(HttpContext.Request.Scheme +"://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" +obj.Id, obj);
        }



    }
}
