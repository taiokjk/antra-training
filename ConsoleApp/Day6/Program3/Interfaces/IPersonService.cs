using Day6.Program3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program3.Interfaces
{
    internal interface IPersonService
    {
        public List<string> GetAddresses(Person p);
        public int GetAge(Person p);
        public decimal GetSalary(Person p);
    }
}
