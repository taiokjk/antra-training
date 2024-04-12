using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8InClass.DataModels
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public string City {  get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\t" +
                    $"Name: {Name}\t" +
                    $"Salary: {Salary}\t" +
                    $"Department: {Department}\t" +
                    $"City: {City}";
        }
    }
}
