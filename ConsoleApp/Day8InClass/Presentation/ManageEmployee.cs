using Day8InClass.DataModels;
using Day8InClass.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Day8InClass.Presentation
{
    internal class ManageEmployee
    {
        private EmployeeRepository _employeeRepository = new EmployeeRepository();

        public void Print()
        {
            List<Employee> employees = _employeeRepository.Search(employee =>
            {
                return employee.City == "Chicago";
            });

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
