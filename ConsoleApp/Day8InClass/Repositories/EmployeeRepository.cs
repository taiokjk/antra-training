using Day8InClass.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8InClass.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository<Employee>
    {
        private List<Employee> _employees = new List<Employee>
        {
            new Employee() {Id = 1, Name="Scot", City="Sterling", Department="IT", Salary=5500 },
            new Employee() {Id = 2, Name="Peter", City="Sterling", Department="HR", Salary=4500 },
            new Employee() {Id = 3, Name="Laura", City="Leesburg", Department="IT", Salary=6500 },
            new Employee() {Id = 4, Name="David", City="Chicago", Department="IT", Salary=5000 },
            new Employee() {Id = 5, Name="Tracy", City="Chicago", Department="HR", Salary=5000 },
            new Employee() {Id = 6, Name="Fiona", City="Sterling", Department="IT", Salary=7500 },
        };

        public List<Employee> Search(Predicate<Employee> condition)
        {
            List<Employee> result = new List<Employee>();

            foreach (var employee in _employees)
                if (condition(employee)) 
                    result.Add(employee);

            return result;
        }

        //public List<Employee> GetByCity(string city)
        //{
        //    List<Employee> result = new List<Employee>();

        //    foreach (var employee in _employees)
        //    {
        //        if (employee.City == city)
        //            result.Add(employee);
        //    }

        //    return result;
        //}

        //public List<Employee> GetByDepartment(string department)
        //{
        //    List<Employee> result = new List<Employee>();

        //    foreach (var employee in _employees)
        //    {
        //        if (employee.Department == department)
        //            result.Add(employee);
        //    }

        //    return result;
        //}
    }
}
