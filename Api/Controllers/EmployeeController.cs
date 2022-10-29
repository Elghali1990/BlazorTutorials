using Infrastructer.Interfaces;
using Infrastructer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee employeeDb;
        public EmployeeController(IEmployee _employee)
        {
            employeeDb = _employee;
        }


        [HttpGet]
        [Route("getAllEmployees")]
        public IActionResult getAll()
        {
            return Ok(employeeDb.GetAllEmployees());
        }

        [HttpGet]
        [Route("getEmployeesById/{id}")]
        public IActionResult getById(int id)
        {
            var emp = employeeDb.GetEmployeeById(id);
            if (emp is null)
            {
                return NotFound("Employee not found");
            }
            return Ok(emp);
        }

        [HttpPost]
        [Route("create")]
        public IActionResult create(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Employe data is incorrect");
            }
            employeeDb.AddEmployee(employee);
            return Ok(employee);
        }

        [HttpDelete]
        [Route("deleteEmployee/{id}")]
        public IActionResult delete(int id)
        {
            var emp = employeeDb.GetEmployeeById(id);
            if (emp is null)
            {
                return NotFound("Employee not found");
            }
            employeeDb.DeleteEmployee(emp);
            return Ok(emp);
        }

        [HttpPut]
        [Route("update/{id}")]
        public IActionResult update(int id,Employee employee)
        {
            var emp = employeeDb.GetEmployeeById(id);
            if (emp is null)
            {
                return NotFound("Employee not found");
            }
            emp.Name = employee.Name;
            emp.Designation = employee.Designation;
            emp.Location = employee.Location;
            emp.Email = employee.Email;
            emp.PhoneNumber = employee.PhoneNumber;
            employeeDb.UpdateEmployee(emp);
            return Ok(emp);
        }

    }
}
