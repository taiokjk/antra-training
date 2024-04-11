using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7InClass.Model
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return new string($"ID: {Id}\n" +
                            $"Name: {Name}\n" +
                            $"Email: {Email}");
        }
    }
}
