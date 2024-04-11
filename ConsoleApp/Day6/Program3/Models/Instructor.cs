using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program3.Models
{
    internal class Instructor : Person
    {
        public List<Course> Courses { get; set; }
    }
}
