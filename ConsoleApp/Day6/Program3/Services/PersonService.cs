using Day6.Program3.Interfaces;
using Day6.Program3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program3.Services
{
    internal class PersonService<T> : CRUDService<T>, IPersonService where T : Person
    {
        public List<string> GetAddresses(Person p)
        {
            return p.Addresses;
        }

        public int GetAge(Person p)
        {
            DateTime now = DateTime.Now;
            int years = (now.Year - p.Birthday.Year - 1) +
                        (((now.Month > p.Birthday.Month) ||
                         ((now.Month == p.Birthday.Month)
                         && (now.Day >= p.Birthday.Day))) ? 1 : 0);

            return years;
        }

        public virtual decimal GetSalary(Person p)
        {
            return p.Salary;
        }
    }
}
