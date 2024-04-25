using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Employee
    {
        [Required]
        public int Id {  get; set; }
        [MaxLength(50)]
        public string? EmployeeName {  get; set; }
        public int Age { get; set; }        
        public int DepartmentId { get; set; }

        // Navigation Property
        public Department Department { get; set; }
    }
}
