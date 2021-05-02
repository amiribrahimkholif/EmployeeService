using EmployeeService.Data;
using EmployeeService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        //Get all employees
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employeeRepository.GetAllEmployees();
        }

        //Get employee By id
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return employeeRepository.GetEmployeeById(id);
        }

        //Add an employee
        [HttpPost]
        public void Post(Employee employee)
        {

            employeeRepository.AddEmployee(employee);
        }

        //update an employee
        [HttpPut]
        public bool Put(int id,Employee employee)
        {

            return employeeRepository.UpdateEmployee(id, employee);
        }
        //Delete an employee by id
        [HttpDelete]
        public bool Delete(int id)
        {
            return employeeRepository.DeleteEmployee(id);
        }
    }
}
