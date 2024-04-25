using Day9InClass.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9InClass.Repositories
{
    internal class EmployeeRepository
    {
        List<Employee> _emplooyee = new List<Employee>();

        public List<Employee> GetEmployee()
        {
            return new List<Employee>
            {
                new Employee() { Id = 1, Name = "Fred", Salary = 5000, Department = "IT", Age = 30 },
                new Employee() { Id = 2, Name = "Laura", Salary = 7000, Department = "HR", Age = 56 },
                new Employee() { Id = 3, Name = "Amy", Salary = 5500, Department = "IT", Age = 32 },
                new Employee() { Id = 4, Name = "Sam", Salary = 7000, Department = "IT", Age = 50 },
                new Employee() { Id = 5, Name = "Peter", Salary = 6000, Department = "HR", Age = 38 },
                new Employee() { Id = 6, Name = "Gary", Salary = 5700, Department = "Marketing", Age = 30 },
                new Employee() { Id = 7, Name = "Fiona", Salary = 8600, Department = "Sales", Age = 32 },
            };
        }
    }
}
