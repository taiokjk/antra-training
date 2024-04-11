using Day6.Program3.Interfaces;
using Day6.Program3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program3.Services
{
    internal class InstructorService : PersonService<Instructor>, IInstructorService
    {
        public decimal GetBonus(int id)
        {
            Instructor instructor = GetById(id);

            if (instructor == null)
                return 0;

            DateTime now = DateTime.Now;
            int years = (now.Year - instructor.JoinDate.Year - 1) +
                        (((now.Month > instructor.JoinDate.Month) ||
                         ((now.Month == instructor.JoinDate.Month) 
                         && (now.Day >= instructor.JoinDate.Day))) ? 1 : 0);

            return years * 1000.0m;
        }

        public override decimal GetSalary(Person p)
        {
            return p.Salary + GetBonus(p.Id);
        }
    }
}
