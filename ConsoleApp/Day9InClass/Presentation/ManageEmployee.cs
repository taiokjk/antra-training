using Day9InClass.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day9InClass.Presentation
{
    internal class ManageEmployee
    {
        EmployeeRepository _employeeRepository = new EmployeeRepository();

        public void Run()
        {
            SelectDemo();
        }

        public void SelectDemo()
        {
            var result = from employee in _employeeRepository.GetEmployee()
                         where employee.Name == "Fred"
                         select new { employee.Name, employee.Salary };
            foreach (var employee in result)
                Console.WriteLine(employee.ToString());

            var result1 = _employeeRepository.GetEmployee()
                            .Where(e => e.Name == "Fred")
                            .Select(e => new { e.Name, e.Salary });

            // Distinct
            var result2 = (from employee in _employeeRepository.GetEmployee()
                           select employee.Department).Distinct();

            var result3 = _employeeRepository.GetEmployee()
                            .Select(e => e.Department)
                            .Distinct();

            // Single record
            var result4 = (from employee in _employeeRepository.GetEmployee()
                           where employee.Department == "IT"
                           select employee).FirstOrDefault();

            try
            {
                var result5 = _employeeRepository.GetEmployee()
                            .Where(e => e.Department == "IT")
                            .SingleOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            // Order by
            Console.WriteLine("Order by query");
            var result6 = from employee in _employeeRepository.GetEmployee()
                          orderby employee.Salary descending, employee.Name ascending
                          select employee;
            foreach (var employee in result6)
                Console.WriteLine(employee.ToString());

            Console.WriteLine("\n\nOrder by method");
            var result7 = _employeeRepository.GetEmployee()
                            .OrderByDescending(e => e.Salary)
                            .ThenBy(e => e.Name);
            foreach (var employee in result7)
                Console.WriteLine(employee.ToString());

            // All & Any            
            bool result8 = _employeeRepository.GetEmployee()
                        .All(e => e.Salary > 8000);
            Console.WriteLine($"\n\nAll employees' salary over 8000: {result8}");

            bool result9 = _employeeRepository.GetEmployee()
                        .Any(e => e.Salary > 8000);
            Console.WriteLine($"Any employees' salary over 8000: {result9}");

            // Group by
            Console.WriteLine("\n\nGroup by");
            var result10 = from employee in _employeeRepository.GetEmployee()
                           group employee by employee.Department;
            foreach (var group in result10)
            {
                Console.WriteLine($"{group.Key} Department");

                foreach (var employee in group)
                    Console.WriteLine(employee.ToString());
            }

            var result11 = _employeeRepository.GetEmployee()
                            .GroupBy(e => e.Department);

            // Aggregation function
            Console.WriteLine("\n\nAggregation");
            var result12 = _employeeRepository.GetEmployee()
                            .Average(e => e.Salary);
            Console.WriteLine($"Avg salary: {result12}");

            // Combining aggregation and group by
            var result13 = _employeeRepository.GetEmployee()
                            .GroupBy(e => e.Department)
                            .Select(g => new
                            {
                                Department = g.Key,
                                AvgSalary = g.Average(e => e.Salary),
                                SumSalary = g.Sum(e => e.Salary)
                            });
            Console.WriteLine("\n\nCombing Gggregation and Group By");
            foreach (var group in result13)
            {
                Console.WriteLine($"Department: {group.Department}\t" +
                    $"Average Salary: {group.AvgSalary}\t" +
                    $"Total Salary: {group.SumSalary}");
            }
        }
    }
}
