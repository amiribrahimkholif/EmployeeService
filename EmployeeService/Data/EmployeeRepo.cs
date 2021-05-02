using EmployeeService.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Data
{
    public class EmployeeRepo : IEmployeeRepository
    {

        private readonly AppDbContext _context;

        public EmployeeRepo(AppDbContext context)
        {
            _context = context;
        }
        //Get all employees
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employee.ToList();
        }

        //Get employee By id
        public Employee GetEmployeeById(int id)
        {
            return _context.Employee.Find(id);
        }

        //Add an employee
        public void AddEmployee([FromBody]Employee employee)
        {

            _context.Employee.Add(employee);
            _context.SaveChanges();
        }

        //update an employee
        public bool UpdateEmployee(int id,[FromBody] Employee employee)
        {

            if (id != employee.Id)
            {
                return false;
            }
            else
            {
                _context.Employee.Update(employee);
                _context.SaveChanges();
                return true;
            }
            
        }
        //Delete an employee by id
        public bool DeleteEmployee(int id)
        {
            var employee = _context.Employee.Find(id);
            if (employee == null)
            {
                return false;
            }
            else
            {
                _context.Employee.Remove(employee);
                _context.SaveChanges();
                return true;
            }
            

        }
    }
}

        

