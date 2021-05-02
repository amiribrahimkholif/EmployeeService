using EmployeeService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Data
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetAllEmployees();
        public Employee GetEmployeeById(int id);
        public void AddEmployee(Employee employee);
        public bool UpdateEmployee(int id, Employee employee);
        public bool DeleteEmployee(int id);

    }
}
