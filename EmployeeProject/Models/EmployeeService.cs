using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Models
{

    public class EmployeeService
    {
        private static List<Employee> employees = new List<Employee>();
        private static int employeeCount = 0;

        public void AddEmployee(Employee employee)
        {
            employee.Id = employeeCount++;
            employees.Add(employee);
        }

        public Employee[] GetAllEmployees()
        {
            var emp = employees
                .ToArray();
            return emp;
        }

        public Employee GetEmployeeById(int id)
        {
            var e = employees
                .Where(b => b.Id == id);
            return e.Single();
        }
    }
}
