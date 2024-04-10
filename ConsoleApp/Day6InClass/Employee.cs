using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6InClass
{
    internal abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Employee(int id)
        {
            Console.WriteLine("Base constructor is called");
            Id = id;
        }

        public abstract void PerformWork();
    }

    internal class FullTimeEmployee : Employee
    {
        public decimal BiweeklyPay { get; set; }
        public string Benefits { get; set; }

        public FullTimeEmployee(int id) : base(id)
        {

        }

        public override void PerformWork()
        {
            Console.WriteLine("Full time employee work 40 hours a week");
        }
    }

    internal sealed class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(int id) : base(id)
        {

        }

        public override void PerformWork()
        {
            Console.WriteLine("Full time employee work 20 hours a week");
        }
    }

    internal class Manager : FullTimeEmployee
    {
        public decimal ExtraBonus { get; set; }

        public Manager(int id) : base (id) { }

        public void AttendMeeting()
        {
            Console.WriteLine("Manager attending a meeting");
        }
    }
}
