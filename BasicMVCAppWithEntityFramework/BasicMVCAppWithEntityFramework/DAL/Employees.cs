using System;
using System.Collections.Generic;
using System.Linq;
using BasicMVCAppWithEntityFramework.Models;

namespace BasicMVCAppWithEntityFramework.DAL
{
    public class Employees
    {
        public List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            using (var employeeMgt = new EmployeeMgtEntities())
            {
                foreach (var employee in employeeMgt.employees.ToList())
                {
                    var newEmp = new Employee
                    {
                        Name = employee.name,
                        Id = employee.empId,
                        Department = employee.department.department1
                    };
                }
            }
            return employees;
        }

        public bool AddNewEmployee(Employee employee)
        {
            using (var employeeMgt = new EmployeeMgtEntities())
            {
                employeeMgt.employees.Add(new employee
                {
                    name = employee.Name
                });

                int rows = employeeMgt.SaveChanges();
                if (rows > 0)
                    return true;
                return false;
            }
        }
    }
}