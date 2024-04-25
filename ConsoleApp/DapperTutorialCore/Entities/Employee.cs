using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorialCore.Entities
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? EmployeeName { get; set; }

        public int? Age { get; set; }
        public int DepartmentId { get; set; }

        // navigation property
        public Department Department { get; set; }
    }
}
