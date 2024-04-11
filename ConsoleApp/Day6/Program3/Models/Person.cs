using Day6.Program3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program3.Models
{
    internal class Person : Base
    {
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public Department BelongToDepartment { get; set; }
        public DateTime Birthday { get; set; }
        public List<string> Addresses { get; set; }
        public decimal Salary { get; set; }
    }
}
