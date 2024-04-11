using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program3.Models
{
    internal class Department : Base
    {
        public string Name { get; set; }
        public Instructor DepartmentHead {  get; set; }
        public decimal Budget { get; set; }
        public List<Course> Courses { get; set; }
    }
}
